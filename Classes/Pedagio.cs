using N2_POO2BIM.Interfaces;
using N2_POO2BIM.Veiculos;
using System;

namespace N2_POO2BIM.Classes
{
    public class Pedagio
    {
        private string identificacao;
        private string localizacao;

        public string InfoPedagio => $"{Identificacao} -- {localizacao}";

        public string Identificacao
        {
            get => identificacao;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A identificação é obrigatória.");

                identificacao = value;
            }
        }
        public string Localizacao
        {
            get => localizacao;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A Localização é obrigatória.");

                localizacao = value;
            }
        }

        public double TotalDePedagioPago { get; private set; }

        public Pedagio(string identificacao, string localizacao, double totalDePedagioPago)
        {
            Identificacao = identificacao;
            Localizacao = localizacao;
            TotalDePedagioPago = totalDePedagioPago;
        }

        public string ReceberPedagio(IPagaPedagio tipoVeiculo)
        {
            double valorPago = tipoVeiculo.PagaPedagio();
            TotalDePedagioPago += valorPago;


            var veiculo = (Veiculo)tipoVeiculo;
            return $"O {veiculo.Identificacao} pagou R${valorPago:F2} reais no {Identificacao}";
        }
    }
}
