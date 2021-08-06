using N2_POO2BIM.Classes;
using N2_POO2BIM.Interfaces;
using System;

namespace N2_POO2BIM.Veiculos
{
    class Carro : Veiculo, ILimpador, IPagaPedagio
    {
        private int quantidadeDePortas;
        public bool Limpador { get; private set; }
        public override string Tipo { get; protected set; } = "Carro";
        public int QuantidadeDePortas
        {
            get => quantidadeDePortas;
            set
            {
                if (value < 1)
                    throw new Exception($"O {Tipo} deve ter ao menos uma porta");
                
                quantidadeDePortas = value;
            }
        }

        public Carro(
            int quantidadeDePortas,
            bool limpador,
            string identificacao,
            int capacidadeDePassageiros,
            Modelo modelo,
            int velocidadeAtual) : base(identificacao, capacidadeDePassageiros, modelo, velocidadeAtual)
        {
            QuantidadeDePortas = quantidadeDePortas;
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
            return 7.00;
        }
    }
}
