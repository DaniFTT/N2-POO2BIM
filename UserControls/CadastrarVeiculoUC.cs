using N2_POO2BIM.Classes;
using N2_POO2BIM.Utilities;
using N2_POO2BIM.Veiculos;
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
    public partial class CadastrarVeiculoUC : UserControl
    {
        public CadastrarVeiculoUC()
        {
            InitializeComponent();
            AtualizaTexBoxsPermitidos();
            CarregaCbModelos(); 
            AtualizaMarcaAtual();
        }


        private void btnCriarVeiculo_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificaCamposVazios())
                {
                    string identificacao = txtIdentificador.Text;
                    int capacidadeDePassageiros = Convert.ToInt32(txtQtePassageiros.Text);
                    Modelo modelo = (Modelo)cbModelo.SelectedItem;
                    string tipo = cbTipo.SelectedItem.ToString();

                    Veiculo veiculoTeste = Global.veiculos.Find(x => x.Identificacao == identificacao && x.Tipo == tipo);

                    if (veiculoTeste == null)
                    {
                        Veiculo veiculo;
                        if (tipo == "Carro")
                        {
                            veiculo = new Carro(Convert.ToInt32(txtQtePortas.Text),
                                                false,
                                                identificacao,
                                                capacidadeDePassageiros,
                                                modelo,
                                                0);
                        }
                        else if (tipo == "Moto")
                        {
                            veiculo = new Moto(identificacao,
                                               capacidadeDePassageiros,
                                               modelo,
                                               0);
                        }
                        else if (tipo == "Caminhão")
                        {
                            veiculo = new Caminhao(Convert.ToInt32(txtQteEixos.Text),
                                                   Convert.ToDouble(txtCargaSuportada.Text),
                                                   false,
                                                   true,
                                                   0.0,
                                                   identificacao,
                                                   capacidadeDePassageiros,
                                                   modelo,
                                                   0);
                        }                          
                        else if (tipo == "Ônibus")
                        {
                            veiculo = new Onibus(Convert.ToInt32(txtQteEixos.Text),
                                                 cbOnibusLeito.SelectedItem.ToString() == "Sim" ? true : false,
                                                 false,
                                                 identificacao,
                                                 capacidadeDePassageiros,
                                                 modelo,
                                                 0);
                        }                           
                        else if (tipo == "Avião")
                        {
                            veiculo = new Aviao(false,
                                                false,
                                                identificacao,
                                                capacidadeDePassageiros,
                                                modelo,
                                                0);
                        }
                        else if (tipo == "Avião de Guerra")
                        {
                            veiculo = new AviaoDeGuerra(false,
                                                        true,
                                                        identificacao,
                                                        capacidadeDePassageiros,
                                                        modelo,
                                                        0);
                        }
                        else if (tipo == "Navio")
                        {
                            veiculo = new Navio(false,
                                                identificacao,
                                                capacidadeDePassageiros,
                                                modelo,
                                                0);
                        }
                        else if (tipo == "Navio de Guerra")
                        {
                            veiculo = new NavioDeGuerra(identificacao,
                                                        capacidadeDePassageiros,
                                                        modelo,
                                                        0);
                        }
                        else
                        {
                            veiculo = new Trem(Convert.ToInt32(txtQteVagoes.Text),
                                               false,
                                               identificacao,
                                               capacidadeDePassageiros,
                                               modelo,
                                               0);
                        }


                        Global.veiculos.Add(veiculo);

                        JsonHandler.SalvarLista(Global.veiculos);

                        MaterialSkin.Controls.MaterialMessageBox.Show("Veiculo cadastrado com sucesso!");
                        LimpaCampos();
                    }
                    else
                        MaterialSkin.Controls.MaterialMessageBox.Show("Esse veiculo já existe!\nNão pode hahver a mesma identificação para o mesmo tipo de veiculo");
                    
                }
                else
                    MaterialSkin.Controls.MaterialMessageBox.Show("Preencha todos os atributos desse veiculo!");

            }
            catch (Exception erro)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(erro.Message);
            }

        }

        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaMarcaAtual();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaTexBoxsPermitidos();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void LimpaCampos()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MaterialSkin.Controls.MaterialTextBox && ctrl.Enabled == true)
                {
                    ((MaterialSkin.Controls.MaterialTextBox)(ctrl)).Clear();
                }
            }
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

        private void CarregaCbModelos()
        {
            if(Global.modelos.Count > 0)
            {
                cbModelo.DataSource = Global.modelos;
                cbModelo.DisplayMember = "Descricao";
                cbModelo.Enabled = true;
            }
            else
            {
                cbModelo.Enabled = false;
            }
        }

        private void AtualizaMarcaAtual()
        {
            if (Global.modelos.Count > 0)
            {
                Modelo mod = Global.modelos.Find(x => x.Codigo == ((Modelo)cbModelo.SelectedValue).Codigo);
                txtMarca.Text = mod.Marca.Descricao;
            }
        }

        private void AtualizaTexBoxsPermitidos()
        {
            txtCargaSuportada.Clear();
            txtQteEixos.Clear();
            txtQteVagoes.Clear();
            txtQtePortas.Clear();
            txtCargaSuportada.Enabled = false;
            txtQteVagoes.Enabled = false;
            txtQteEixos.Enabled = false;
            cbOnibusLeito.Enabled = false;
            txtQtePortas.Enabled = false;


            if (cbTipo.SelectedItem.ToString() == "Carro")
            {
                txtQtePortas.Enabled = true;
            }
            else if (cbTipo.SelectedItem.ToString() == "Caminhão")
            {
                txtCargaSuportada.Enabled = true;
                txtQteEixos.Enabled = true;
            }
            else if (cbTipo.SelectedItem.ToString() == "Ônibus")
            {
                txtQteEixos.Enabled = true;
                cbOnibusLeito.Enabled = true;
            }
            else if (cbTipo.SelectedItem.ToString() == "Trem")
            {
                txtQteVagoes.Enabled = true;
            }
        }

        private void btnGerarDeCadaTipo_Click(object sender, EventArgs e)
        {
            try
            {
                if (Global.marcas.Count > 0)
                {
                    if (Global.marcas.Find(x => x.Descricao == "Volkswagen" || x.Descricao == "Honda" || x.Descricao == "Volvo" || x.Descricao == "Airbus" || x.Descricao == "Trenzs") == null)
                        Global.marcas.Add(new Marca(Global.marcas.Last().Codigo + 1, "Volkswagen"));
                    else
                        throw new Exception("Esses Veiculos de teste já existem!");
                }
                else
                {
                    Global.marcas.Add(new Marca(1, "Volkswagen"));
                }
                Global.marcas.Add(new Marca(Global.marcas.Last().Codigo + 1, "Fiat"));
                Global.marcas.Add(new Marca(Global.marcas.Last().Codigo + 1, "Hyundai"));
                Global.marcas.Add(new Marca(Global.marcas.Last().Codigo + 1, "Honda"));
                Global.marcas.Add(new Marca(Global.marcas.Last().Codigo + 1, "Yamaha"));
                Global.marcas.Add(new Marca(Global.marcas.Last().Codigo + 1, "Kawasaki"));
                Global.marcas.Add(new Marca(Global.marcas.Last().Codigo + 1, "Volvo"));
                Global.marcas.Add(new Marca(Global.marcas.Last().Codigo + 1, "Scania"));
                Global.marcas.Add(new Marca(Global.marcas.Last().Codigo + 1, "Mercedez-Benz"));
                Global.marcas.Add(new Marca(Global.marcas.Last().Codigo + 1, "Airbus"));
                Global.marcas.Add(new Marca(Global.marcas.Last().Codigo + 1, "Bombardier"));
                Global.marcas.Add(new Marca(Global.marcas.Last().Codigo + 1, "Boeing"));
                Global.marcas.Add(new Marca(Global.marcas.Last().Codigo + 1, "Kleven"));
                Global.marcas.Add(new Marca(Global.marcas.Last().Codigo + 1, "Brodosplit"));
                Global.marcas.Add(new Marca(Global.marcas.Last().Codigo + 1, "Ulstein"));
                Global.marcas.Add(new Marca(Global.marcas.Last().Codigo + 1, "Trenzs"));

                if (Global.modelos.Count > 0)
                {
                    Global.modelos.Add(new Modelo(Global.modelos.Count + 1, "Fox", Global.marcas.Find(x => x.Descricao == "Volkswagen")));
                }
                else
                {
                    Global.modelos.Add(new Modelo(1, "Fox", Global.marcas.Find(x => x.Descricao == "Volkswagen")));
                }
                Global.modelos.Add(new Modelo(Global.modelos.Count + 1, "Palio", Global.marcas.Find(x => x.Descricao == "Fiat")));
                Global.modelos.Add(new Modelo(Global.modelos.Count + 1, "HB20", Global.marcas.Find(x => x.Descricao == "Hyundai")));
                Global.modelos.Add(new Modelo(Global.modelos.Count + 1, "CG 150", Global.marcas.Find(x => x.Descricao == "Honda")));
                Global.modelos.Add(new Modelo(Global.modelos.Count + 1, "Ninja 300", Global.marcas.Find(x => x.Descricao == "Kawasaki")));
                Global.modelos.Add(new Modelo(Global.modelos.Count + 1, "Fazer 250", Global.marcas.Find(x => x.Descricao == "Yamaha")));
                Global.modelos.Add(new Modelo(Global.modelos.Count + 1, "FH 540", Global.marcas.Find(x => x.Descricao == "Volvo")));
                Global.modelos.Add(new Modelo(Global.modelos.Count + 1, "R 450", Global.marcas.Find(x => x.Descricao == "Scania")));
                Global.modelos.Add(new Modelo(Global.modelos.Count + 1, "Actros 2651", Global.marcas.Find(x => x.Descricao == "Mercedez-Benz")));
                Global.modelos.Add(new Modelo(Global.modelos.Count + 1, "CAMPIONE R 21", Global.marcas.Find(x => x.Descricao == "Volvo")));
                Global.modelos.Add(new Modelo(Global.modelos.Count + 1, "IDEALE R 31", Global.marcas.Find(x => x.Descricao == "Volkswagen")));
                Global.modelos.Add(new Modelo(Global.modelos.Count + 1, "APACHE U 443", Global.marcas.Find(x => x.Descricao == "Mercedez-Benz")));
                Global.modelos.Add(new Modelo(Global.modelos.Count + 1, "A320", Global.marcas.Find(x => x.Descricao == "Airbus")));
                Global.modelos.Add(new Modelo(Global.modelos.Count + 1, "737", Global.marcas.Find(x => x.Descricao == "Boeing")));
                Global.modelos.Add(new Modelo(Global.modelos.Count + 1, "CRJ Series", Global.marcas.Find(x => x.Descricao == "Bombardier")));
                Global.modelos.Add(new Modelo(Global.modelos.Count + 1, "Finnmarken", Global.marcas.Find(x => x.Descricao == "Kleven")));
                Global.modelos.Add(new Modelo(Global.modelos.Count + 1, "Hondius", Global.marcas.Find(x => x.Descricao == "Brodosplit")));
                Global.modelos.Add(new Modelo(Global.modelos.Count + 1, "CX103", Global.marcas.Find(x => x.Descricao == "Ulstein")));
                Global.modelos.Add(new Modelo(Global.modelos.Count + 1, "Trem-Bala01", Global.marcas.Find(x => x.Descricao == "Trenzs")));


                Global.veiculos.Add(new Carro(4, false, "CAR-0001", 5, Global.modelos.Find(x => x.Descricao == "Fox"), 0));

                Global.veiculos.Add(new Moto("MOT-0001", 2, Global.modelos.Find(x => x.Descricao == "CG 150"), 0));

                Global.veiculos.Add(new Caminhao(6, 500, false, true, 0.00, "CAM-0001", 2, Global.modelos.Find(x => x.Descricao == "Actros 2651"), 0));

                Global.veiculos.Add(new Onibus(5, true, false, "ONB-0001", 40, Global.modelos.Find(x => x.Descricao == "CAMPIONE R 21"), 0));

                Global.veiculos.Add(new Aviao(false, false, "AVI-0001", 50, Global.modelos.Find(x => x.Descricao == "A320"), 0));

                Global.veiculos.Add(new AviaoDeGuerra(false, true, "AVG-0001", 1, Global.modelos.Find(x => x.Descricao == "737"), 0));

                Global.veiculos.Add(new Navio(false, "NVO-0001", 30, Global.modelos.Find(x => x.Descricao == "Finnmarken"), 0));

                Global.veiculos.Add(new NavioDeGuerra("NVG-0001", 10, Global.modelos.Find(x => x.Descricao == "CX103"), 0));

                Global.veiculos.Add(new Trem(8, false, "TRE-0001", 80, Global.modelos.Find(x => x.Descricao == "Trem-Bala01"), 0));

                CarregaCbModelos();

                JsonHandler.SalvarLista(Global.marcas);
                JsonHandler.SalvarLista(Global.modelos);
                JsonHandler.SalvarLista(Global.veiculos);
            }
            catch (Exception erro)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(erro.Message);
            }
            
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQteVagoes_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel11_Click(object sender, EventArgs e)
        {

        }

        private void cbOnibusLeito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCargaSuportada_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQteEixos_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel10_Click(object sender, EventArgs e)
        {

        }

        private void txtQtePortas_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel9_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void txtQtePassageiros_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtIdentificador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
