using N2_POO2BIM.Classes;
using N2_POO2BIM.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2_POO2BIM.UserControls
{
    public partial class PedagiosUC : UserControl
    {
        private double total = 0.0;
        public PedagiosUC()
        {
            InitializeComponent();
            AtualizaListView();

        }

        private void btnCriarPedagio_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaCamposVazios())
                {
                    string identificacao = txtIdentificacao.Text;
                    string localizacao = txtLocalizacao.Text;

                    if(Global.pedagios.Find(x => x.Identificacao == identificacao) == null)
                    {
                        Pedagio pedagio = new Pedagio(identificacao, localizacao, 0.00);
                        Global.pedagios.Add(pedagio);

                        JsonHandler.SalvarLista(Global.pedagios);

                        AdicionaItemList(pedagio);

                    }
                    else
                        MaterialSkin.Controls.MaterialMessageBox.Show("Essa identificação de pedágio já existe!");
                }
                else
                    MaterialSkin.Controls.MaterialMessageBox.Show("Preencha todos os atributos desse veiculo!");


            }
            catch (Exception erro)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(erro.Message);
            }
        }
        private void AtualizaListView()
        {
            total = 0.0;
            if (!(Global.pedagios == null))
            {
                listViewPedagios.Items.Clear();

                foreach (var pedagio in Global.pedagios)
                {
                    AdicionaItemList(pedagio);
                }
            }
            lblTotal.Text = $"R$ {total:f2}";
        }

        private void AdicionaItemList(Pedagio pedagio)
        {
            var row = new string[] { pedagio.Identificacao, pedagio.Localizacao, pedagio.TotalDePedagioPago.ToString("f2") };

            var lvi = new ListViewItem(row)
            {
                Tag = pedagio
            };

            listViewPedagios.Items.Add(lvi);

            total += pedagio.TotalDePedagioPago;
        }

        private bool VerificaCamposVazios()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MaterialSkin.Controls.MaterialTextBox && ctrl.Enabled == true && (string.IsNullOrWhiteSpace(ctrl.Text)))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdentificacao.Clear();
            txtLocalizacao.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Pedagio pedagioSelected = (Pedagio)listViewPedagios.SelectedItems[0].Tag;
                if (pedagioSelected != null)
                {
                    Global.pedagios.Remove(pedagioSelected);

                    JsonHandler.SalvarLista(Global.pedagios);

                    listViewPedagios.Items.Remove(listViewPedagios.SelectedItems[0]);
                }
            }
            catch (Exception)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show("Selecione pelo menos um pedagio para excluir!");
            }
        }
    }
}
