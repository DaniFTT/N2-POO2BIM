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
    partial class MarcasUC : UserControl
    {
        private int codigo;
        public MarcasUC()
        {
            InitializeComponent();
            AtualizaListView();

            IncrementaCodigo();
        }

        private void btnCriarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtDescricao.Text;
                Marca marcaTeste = Global.marcas.Find(x => x.Codigo == codigo || x.Descricao == descricao);

                if (marcaTeste == null)
                {
                    Marca marca = new Marca(codigo, descricao);
                    Global.marcas.Add(marca);

                    JsonHandler.SalvarLista(Global.marcas);

                    AdicionaItemList(marca);

                    IncrementaCodigo();
                }
                else 
                    MaterialSkin.Controls.MaterialMessageBox.Show("Esse marca já existe!");

            }
            catch(Exception erro)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(erro.Message);
            }


        }

        private void IncrementaCodigo()
        {
            if (Global.marcas.Count > 0)
            {
                codigo = Global.marcas.Last().Codigo + 1;
                txtCodigo.Text = codigo.ToString();
            }
            else
            {
                codigo = 1;
                txtCodigo.Text = codigo.ToString();
            }
        }
        private void AtualizaListView()
        {
            if (!(Global.marcas == null))
            {
                listViewMarcas.Items.Clear();

                foreach (var marca in Global.marcas)
                {
                    AdicionaItemList(marca);
                }
            }       
        }

        private void AdicionaItemList(Marca marca)
        {
            var row = new string[] { marca.Codigo.ToString(), marca.Descricao };

            var lvi = new ListViewItem(row)
            {
                Tag = marca
            };

            listViewMarcas.Items.Add(lvi);
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Marca selectedMarca = (Marca)listViewMarcas.SelectedItems[0].Tag;
                if (selectedMarca != null)
                {
                    Global.marcas.Remove(selectedMarca);

                    JsonHandler.SalvarLista(Global.marcas);

                    listViewMarcas.Items.Remove(listViewMarcas.SelectedItems[0]);
                }
            }
            catch (Exception)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show("Selecione pelo menos uma marca para excluir!");
            }
        }

        private void MarcasUC_Load(object sender, EventArgs e)
        {

        }
    }
}
