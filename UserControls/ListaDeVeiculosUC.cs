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
    public partial class ListaDeVeiculosUC : UserControl
    {
        public ListaDeVeiculosUC()
        {
            InitializeComponent();
            AtualizaListView();
        }

        public void AtualizaListView()
        {
            if (!(Global.veiculos == null))
            {
                listViewVeiculos.Items.Clear();

                foreach (Veiculo veiculo in Global.veiculos)
                {
                    var row = new string[] { veiculo.Identificacao, veiculo.Tipo, veiculo.Modelo.Descricao, veiculo.Modelo.Marca.Descricao };

                    var lvi = new ListViewItem(row)
                    {
                        Tag = veiculo
                    };

                    listViewVeiculos.Items.Add(lvi);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo selectedVeiculo = (Veiculo)listViewVeiculos.SelectedItems[0].Tag;
                if (selectedVeiculo != null)
                {
                    Global.veiculos.Remove(selectedVeiculo);

                    JsonHandler.SalvarLista(Global.veiculos);

                    txtDetalhes.Clear();
                    AtualizaListView();
                }
            }
            catch (Exception)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show("Selecione pelo menos um Veiculo para excluir!");
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo selectedVeiculo = (Veiculo)listViewVeiculos.SelectedItems[0].Tag;
                if (selectedVeiculo != null)
                {
                    txtDetalhes.Text = RetornaDetalhesVeiculo(selectedVeiculo);
                }
                else
                {
                    MaterialSkin.Controls.MaterialMessageBox.Show("Selecione apenas UM veiculo para ver os detalhes");
                }
            }
            catch (Exception)
            {
                MaterialSkin.Controls.MaterialMessageBox.Show("Selecione pelo menos um Veiculo para ver s detalhes!");
            }
        }

        private string RetornaDetalhesVeiculo(Veiculo selectedVeiculo)
        {
            string detalhes = $" Detalhes:\n\n  Velocidade Atual: {selectedVeiculo.VelocidadeAtual} Km/h\n\n" +
                $"  Capacidade de Passageiros: {selectedVeiculo.CapacidadeDePassageiros}\n\n";
                

            if(selectedVeiculo is ILimpador limpador)
            {
                if (limpador.Limpador)
                    detalhes += $"  Limpador: Ligado\n\n";
                else
                    detalhes += $"  Limpador: Desligado\n\n";
            }
            if (selectedVeiculo is IPagaPedagio pagaPedagio)
            {
                detalhes += $"  Valor de Pedagio: R$ {pagaPedagio.PagaPedagio():f2}\n\n";
            }

            if(selectedVeiculo is Caminhao caminhao)
            {
                detalhes += 
                    $"  Capacidade Máxima Suportada: {caminhao.CapacidadeMaxima} kg\n\n" +
                    $"  Carga Atual: {caminhao.PesoCarregado} kg\n\n" +
                    $"  Quantidade de Eixos: {caminhao.QuantidadeDeEixos}\n\n";
            }
            else if(selectedVeiculo is Carro carro)
            {
                detalhes += $"  Quantidade de portas: {carro.QuantidadeDePortas}\n\n";
            }
            else if(selectedVeiculo is Onibus onibus)
            {
                detalhes += $"  Quantidade de Eixos: {onibus.QuantidadeDeEixos}\n\n";

                if(onibus.Leito)
                    detalhes += $"  Ônibus Leito: Sim\n\n";
                else 
                    detalhes += $"  Ônibus Leito: Não\n\n";
            }
            else if (selectedVeiculo is IAviao aviao)
            {
                if(aviao.Voando)
                    detalhes += $"  Status do Avião: Voando\n\n";
                else
                    detalhes += $"  Status do Avião: Em Terra\n\n";

                if(selectedVeiculo is AviaoDeGuerra aviaoDeGuerra)
                {
                    if (aviaoDeGuerra.Piloto)
                        detalhes += $"  Status do Piloto: No Avião\n\n";
                    else
                        detalhes += $"  Status do Piloto: Ejetado do Avião\n\n";
                }
            }
            else if (selectedVeiculo is INavio navio)
            {
                if (navio.Atracado)
                    detalhes += $"  Status do Navio: Atracado\n\n";
                else
                    detalhes += $"  Status do Navio: Navegando\n\n";
            }
            else if (selectedVeiculo is Trem trem)
            {
                detalhes += $"  Quantidade de Vagoês: {trem.QuantidadeDeVagoes}\n\n";
            }

            return detalhes;
        }
    }
}
