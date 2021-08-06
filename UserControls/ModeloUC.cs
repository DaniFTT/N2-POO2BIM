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
    public partial class ModeloUC : UserControl
    {
        private int codigo;
        public ModeloUC()
        {
            InitializeComponent();
            AtualizaListView();
            AtualizaMarcas();
            IncrementaCodigo();
        }

        private void btnCriarModelo_Click(object sender, EventArgs e)
        {
            try
            {               
                string descricao = txtDescricao.Text;
                Marca marca = (Marca)cbMarca.SelectedItem;

                Modelo mod = Global.modelos.Find(x => x.Codigo == codigo || (x.Descricao == descricao && x.Marca.Descricao == marca.Descricao));

                if (mod == null)
                {
                    Modelo modelo = new Modelo(codigo, descricao, marca);
                    Global.modelos.Add(modelo);

                    JsonHandler.SalvarLista(Global.modelos);

                    AdicionaItemList(modelo);

                    IncrementaCodigo();
                }
                else
                    MaterialSkin.Controls.MaterialMessageBox.Show("Esse modelo já existe!");

            }
            catch (Exception erro)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(erro.Message);
            }
        }

        private void IncrementaCodigo()
        {
            if (Global.modelos.Count > 0)
            {
                codigo = Global.modelos.Last().Codigo + 1;
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
            if (!(Global.modelos == null))
            {
                listViewModelos.Items.Clear();

                foreach (var modelo in Global.modelos)
                {
                    AdicionaItemList(modelo);
                }
            }
        }

        private void AdicionaItemList(Modelo modelo)
        {
            var row = new string[] { modelo.Codigo.ToString(), modelo.Descricao, modelo.Marca.Descricao };

            var lvi = new ListViewItem(row)
            {
                Tag = modelo
            };

            listViewModelos.Items.Add(lvi);
        }

        private void AtualizaMarcas()
        {
            if (Global.marcas.Count > 0)
            {
                cbMarca.DataSource = Global.marcas;
                cbMarca.DisplayMember = "Descricao";
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo modeloSelected = (Modelo)listViewModelos.SelectedItems[0].Tag;
                if (modeloSelected != null)
                {
                    Global.modelos.Remove(modeloSelected);

                    JsonHandler.SalvarLista(Global.modelos);

                    listViewModelos.Items.Remove(listViewModelos.SelectedItems[0]);
                }
            }
            catch (Exception)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show("Selecione pelo menos um Modelo para excluir!");
            }
        }
    }
}
