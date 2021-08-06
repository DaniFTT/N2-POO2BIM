using N2_POO2BIM.Classes;
using N2_POO2BIM.Interfaces;
using System;

namespace N2_POO2BIM.Veiculos
{
    class Onibus : Veiculo, ILimpador, IPagaPedagio
    {
        private int quantidadeDeEixos;
        public override string Tipo { get; protected set; } = "Ônibus";
        public bool Leito { get; private set; }
        public bool Limpador { get; private set; }
        public int QuantidadeDeEixos
        {
            get => quantidadeDeEixos;
            set
            {
                if (value <= 2)
                    throw new Exception($"A quantidade de eixos do {Tipo} não pode ser menor ou igual a zero!");

                quantidadeDeEixos = value;
            }
        }

        public Onibus(
            int quantidadeDeEixos,
            bool leito,
            bool limpador,
            string identificacao,
            int capacidadeDePassageiros,
            Modelo modelo,
            int velocidadeAtual) : base(identificacao, capacidadeDePassageiros, modelo, velocidadeAtual)
        {
            QuantidadeDeEixos = quantidadeDeEixos;
            Leito = leito;
            Limpador = limpador;
        }

        public string ControlaLimpador()
        {
            if (Limpador == true)
            {
                Limpador = false;
                return $"O Limpador do {Tipo} {Identificacao} está Desligado";
            }
            else
            {
                Limpador = true;
                return $"O Limpador do {Tipo} {Identificacao} está ligado";
            }
        }

        public double PagaPedagio()
        {
            double valorPedagio = (8.5 * quantidadeDeEixos);

            return valorPedagio;
        }
    }
}
