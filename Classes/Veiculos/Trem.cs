using N2_POO2BIM.Classes;
using N2_POO2BIM.Interfaces;
using System;

namespace N2_POO2BIM.Veiculos
{
    class Trem : Veiculo, ILimpador
    {
        private int quantidadeDeVagoes;
        public bool Limpador { get; private set; }
        public override string Tipo { get; protected set; } = "Trem";
        public int QuantidadeDeVagoes
        {
            get => quantidadeDeVagoes;
            set
            {
                if (value < 1)
                    throw new Exception($"A quantidade de vagoes do {Tipo} não pode ser menor ou igual a zero!");

                quantidadeDeVagoes = value;
            }
        }

        public Trem(
            int quantidadeDeVagoes,
            bool limpador,
            string identificacao,
            int capacidadeDePassageiros,
            Modelo modelo,
            int velocidadeAtual) : base(identificacao, capacidadeDePassageiros, modelo, velocidadeAtual)
        {
            QuantidadeDeVagoes = quantidadeDeVagoes;
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
    }
}
