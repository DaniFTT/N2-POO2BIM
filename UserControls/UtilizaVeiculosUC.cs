using N2_POO2BIM.Classes;
using N2_POO2BIM.Interfaces;
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
    public partial class UtilizaVeiculosUC : UserControl
    {
        public UtilizaVeiculosUC()
        {
            InitializeComponent();
            CarregaVeiculos();
            CarregaPedagios();
            AtualizaAcoesPossiveis();
            txtAcoes.Text = Global.historicoDeAcoes;
        }


        /// <summary>
        /// Switch do que controla o limpador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void swLimpador_CheckedChanged(object sender, EventArgs e)
        {
            if (swLimpador.Checked)
            {
                if(((ILimpador)cbVeiculos.SelectedItem).Limpador == false)
                {
                    ExecutaLimpador();
                }
            }
            else
            {
                if (((ILimpador)cbVeiculos.SelectedItem).Limpador == true)
                {
                    ExecutaLimpador();
                }
            }
        }
        private void ExecutaLimpador()
        {
            try
            {
                //encontra o veiculo atual
                Global.historicoDeAcoes += Environment.NewLine + ((ILimpador)cbVeiculos.SelectedItem).ControlaLimpador();
                txtAcoes.Text = Global.historicoDeAcoes;
                JsonHandler.SalvarLista(Global.veiculos);
            }
            catch (Exception erro)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(erro.Message);
            }
        }


        /// <summary>
        /// Button que paga o pedagio do veiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPagarPedagio_Click(object sender, EventArgs e)
        {
            try
            {
                Pedagio ped = ((Pedagio)cbPedagios.SelectedItem);
                IPagaPedagio veic = ((IPagaPedagio)cbVeiculos.SelectedItem);

                Global.historicoDeAcoes += Environment.NewLine + ped.ReceberPedagio(veic);
                txtAcoes.Text = Global.historicoDeAcoes;

                JsonHandler.SalvarLista(Global.pedagios);
            }
            catch (Exception erro)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(erro.Message);
            }
        }

        /// <summary>
        /// Button para acelerar o veiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAcelerar_Click(object sender, EventArgs e)     
        {
            try
            {
                Global.historicoDeAcoes += Environment.NewLine + ((Veiculo)cbVeiculos.SelectedItem).Acelerar();
                txtAcoes.Text = Global.historicoDeAcoes;

                JsonHandler.SalvarLista(Global.veiculos);
            }
            catch (Exception erro)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(erro.Message);
            }

        }

        /// <summary>
        /// Button para desacelerar o Veiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesacelerar_Click(object sender, EventArgs e)
        {
            try
            {
                Global.historicoDeAcoes += Environment.NewLine + ((Veiculo)cbVeiculos.SelectedItem).Desacelerar();
                txtAcoes.Text = Global.historicoDeAcoes;

                JsonHandler.SalvarLista(Global.veiculos);
            }
            catch (Exception erro)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(erro.Message);
            }
        }
       
        private void btnEmpinar_Click(object sender, EventArgs e)
        {
            Global.historicoDeAcoes += Environment.NewLine + ((Moto)cbVeiculos.SelectedItem).Empinar();
            txtAcoes.Text = Global.historicoDeAcoes;
        }

        private void btnDecolar_Click(object sender, EventArgs e)
        {
            try
            {
                IAviao aviao = ((IAviao)cbVeiculos.SelectedItem);
                Global.historicoDeAcoes += Environment.NewLine + aviao.Decolar();
                txtAcoes.Text = Global.historicoDeAcoes;

                JsonHandler.SalvarLista(Global.veiculos);
            }
            catch (Exception erro)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(erro.Message);
            }

        }

        private void btnPousar_Click(object sender, EventArgs e)
        {
            try
            {
                IAviao aviao = ((IAviao)cbVeiculos.SelectedItem);
                Global.historicoDeAcoes += Environment.NewLine + aviao.Pousar();
                txtAcoes.Text = Global.historicoDeAcoes;

                JsonHandler.SalvarLista(Global.veiculos);
            }
            catch (Exception erro)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(erro.Message);
            }
        }

        private void btnArremeter_Click(object sender, EventArgs e)
        {
            try
            {
                IAviao aviao = ((IAviao)cbVeiculos.SelectedItem);
                Global.historicoDeAcoes += Environment.NewLine + aviao.Arremeter();
                txtAcoes.Text = Global.historicoDeAcoes;

                JsonHandler.SalvarLista(Global.veiculos);
            }
            catch (Exception erro)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(erro.Message);
            }
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbVeiculos.SelectedItem is AviaoDeGuerra)
                {
                    Global.historicoDeAcoes += Environment.NewLine + ((AviaoDeGuerra)cbVeiculos.SelectedItem).Atacar();
                    txtAcoes.Text = Global.historicoDeAcoes;
                }
                else
                {
                    Global.historicoDeAcoes += Environment.NewLine + ((NavioDeGuerra)cbVeiculos.SelectedItem).Atacar();
                    txtAcoes.Text = Global.historicoDeAcoes;
                }
            }
            catch (Exception erro)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(erro.Message);
            }


        }
 
        private void btnEjetar_Click(object sender, EventArgs e)
        {
            try
            {
                Global.historicoDeAcoes += Environment.NewLine + ((AviaoDeGuerra)cbVeiculos.SelectedItem).Ejetar();
                txtAcoes.Text = Global.historicoDeAcoes;

                JsonHandler.SalvarLista(Global.veiculos);
            }
            catch (Exception erro)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(erro.Message);
            }

        }

        private void btnAtracar_Click(object sender, EventArgs e)
        {
            try
            {
                INavio navio = ((INavio)cbVeiculos.SelectedItem);
                Global.historicoDeAcoes += Environment.NewLine + navio.Atracar();
                txtAcoes.Text = Global.historicoDeAcoes;

                JsonHandler.SalvarLista(Global.veiculos);
            }
            catch (Exception erro)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(erro.Message);
            }

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                Global.historicoDeAcoes += Environment.NewLine + ((Caminhao)cbVeiculos.SelectedItem).Carregar(Convert.ToDouble(txtCarga.Text));
                txtAcoes.Text = Global.historicoDeAcoes;
            }
            catch (Exception erro)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(erro.Message);
            }
            finally
            {
                JsonHandler.SalvarLista(Global.veiculos);
            }
        }

        private void btnDescarregar_Click(object sender, EventArgs e)
        {
            try
            {
                Global.historicoDeAcoes += Environment.NewLine + ((Caminhao)cbVeiculos.SelectedItem).Descarregar();
                txtAcoes.Text = Global.historicoDeAcoes;

                JsonHandler.SalvarLista(Global.veiculos);
            }
            catch (Exception erro)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show(erro.Message);
            }
        }


        /// <summary>
        /// preenche ComboBox dos veiculos
        /// </summary>
        private void CarregaVeiculos()
        {
            cbVeiculos.DataSource = Global.veiculos;
            cbVeiculos.DisplayMember = "InfoVeiculo";
        }

        /// <summary>
        /// Preenche o ComboBox dos pedagios
        /// </summary>
        private void CarregaPedagios()
        {
            cbPedagios.DataSource = Global.pedagios;
            cbPedagios.DisplayMember = "InfoPedagio";
        }


        private void btnLimparTxt_Click(object sender, EventArgs e)
        {
            Global.historicoDeAcoes = "";
            txtAcoes.Text = Global.historicoDeAcoes;
        }


        private void cbVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaAcoesPossiveis();
        }

        /// <summary>
        /// Atualiza as ações possiveis dependendo do veiculo selecionado no momento
        /// </summary>
        private void AtualizaAcoesPossiveis()
        {
            //seta todos inicialmente como desabilitados para apos isso verificar qual tipo de veiculo é
            //e liberar os metodos correspondentes
            btnEmpinar.Enabled = false;
            btnAtacar.Enabled = false;
            btnArremeter.Enabled = false;
            btnAtracar.Enabled = false;
            btnCarregar.Enabled = false;
            btnDecolar.Enabled = false;
            btnEjetar.Enabled = false;
            btnPousar.Enabled = false;
            btnPagarPedagio.Enabled = false;
            btnDescarregar.Enabled = false;
            txtCarga.Enabled = false;
            cbPedagios.Enabled = false;
            swLimpador.Enabled = false;
            btnAcelerar.Enabled = false;
            btnDesacelerar.Enabled = false;
            cbVeiculos.Enabled = false;

            if (Global.veiculos.Count != 0)
            {
                btnAcelerar.Enabled = true;
                btnDesacelerar.Enabled = true;
                cbVeiculos.Enabled = true;

                // verifica se o veiculo possui limpador para habilitar o liga/desliga
                if (cbVeiculos.SelectedItem is ILimpador)
                {
                    swLimpador.Enabled = true;
                    if (((ILimpador)cbVeiculos.SelectedItem).Limpador == true)
                    {
                        swLimpador.Checked = true;
                    }
                    else
                    {
                        swLimpador.Checked = false;
                    }
                }

                //verifica se o veiculo paga pedagio para liberar o comboBox de pedagios
                if (cbVeiculos.SelectedItem is IPagaPedagio && Global.pedagios.Count > 0)
                {
                    cbPedagios.Enabled = true;
                    btnPagarPedagio.Enabled = true;
                }

                //verifica se é algum tipo de aviao
                if (cbVeiculos.SelectedItem is IAviao)
                {
                    btnDecolar.Enabled = true;
                    btnPousar.Enabled = true;
                    btnArremeter.Enabled = true;
                }

                //verifica se é algum tipo de Navio
                if (cbVeiculos.SelectedItem is INavio)
                {
                    btnAtracar.Enabled = true;
                }


                if (cbVeiculos.SelectedItem is Moto)
                {
                    btnEmpinar.Enabled = true;
                }
                else if (cbVeiculos.SelectedItem is Caminhao)
                {
                    txtCarga.Enabled = true;
                    btnCarregar.Enabled = true;
                    btnDescarregar.Enabled = true;
                }
                else if (cbVeiculos.SelectedItem is AviaoDeGuerra)
                {
                    btnAtacar.Enabled = true;
                    btnEjetar.Enabled = true;
                }
                else if (cbVeiculos.SelectedItem is NavioDeGuerra)
                {
                    btnAtacar.Enabled = true;
                }

                lblVeiculoAtual.Text = $"{((Veiculo)cbVeiculos.SelectedItem).InfoVeiculo}";
            }
        }
    }
}
