using MaterialSkin.Controls;
using N2_POO2BIM.Classes;
using N2_POO2BIM.Interfaces;
using N2_POO2BIM.UserControls;
using N2_POO2BIM.Utilities;
using N2_POO2BIM.Veiculos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N2_POO2BIM
{
    partial class TelaPrincipal : MaterialForm
    {
        public MaterialSkin.MaterialSkinManager materialSkinManager;
        private UserControl _objForm;

        public TelaPrincipal()
        {
            InitializeComponent();
            InicializaTema();
            AtualizaTodasListas();

            tbControlmenu.Selected += TbControlmenu_Selected;

            Text = "Tela Inicial";
        }

        private void TbControlmenu_Selected(object sender, TabControlEventArgs e)
        {
            AtualizaTodasListas();

            _objForm?.Dispose();
            _objForm?.Controls.Remove(_objForm);


            if (tbControlmenu.SelectedTab == tbCadastroVeiculos)
            {
                Text = "Cadastrar Veiculos";
                _objForm = new CadastrarVeiculoUC
                {
                    Dock = DockStyle.Fill
                };
            }
            else if (tbControlmenu.SelectedTab == tbUtilizaVeiculos)
            {
                Text = "Utilizar Veiculos";
                _objForm = new UtilizaVeiculosUC
                {
                    Dock = DockStyle.Fill
                };

            }
            else if (tbControlmenu.SelectedTab == tbListaDeVeiculos)
            {
                Text = "Lista de Veiculos";
                _objForm = new ListaDeVeiculosUC
                {
                    Dock = DockStyle.Fill
                };
            }
            else if (tbControlmenu.SelectedTab == tbMarcas)
            {
                Text = "Marcas";
                _objForm = new MarcasUC
                {
                    Dock = DockStyle.Fill
                };
            }
            else if (tbControlmenu.SelectedTab == tbModelos)
            {
                Text = "Modelos";
                _objForm = new ModeloUC
                {
                    Dock = DockStyle.Fill
                };
            }
            else if (tbControlmenu.SelectedTab == tbPedagios)
            {
                Text = "Pedágios";
                _objForm = new PedagiosUC
                {
                    Dock = DockStyle.Fill
                };

            }
            else
            {
                return;
            }
            tbControlmenu.SelectedTab.Controls.Add(_objForm);
            _objForm.Show();

        }

        public void InicializaTema()
        {
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500,
                                                                           MaterialSkin.Primary.Indigo700,
                                                                           MaterialSkin.Primary.Indigo100,
                                                                           MaterialSkin.Accent.Blue100,
                                                                           MaterialSkin.TextShade.WHITE);

        }      

        public void AtualizaTodasListas()
        {
            Global.modelos = JsonHandler.ListaDeModelos();
            Global.marcas = JsonHandler.ListaDeMarcas();
            Global.veiculos = JsonHandler.ListaDeVeiculos();
            Global.pedagios = JsonHandler.ListaDePedagios();
        }
    }
}
