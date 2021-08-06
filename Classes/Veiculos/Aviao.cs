using N2_POO2BIM.Classes;
using N2_POO2BIM.Interfaces;
using System;

namespace N2_POO2BIM.Veiculos
{
    class Aviao : Veiculo, IAviao, ILimpador
    {
        public bool Voando { get; set; }
        public bool Limpador { get; private set; }
        public override string Tipo { get; protected set; } = "Avião";

        public Aviao(
            bool limpador,
            bool voando,
            string identificacao,
            int capacidadeDePassageiros,
            Modelo modelo,
            int velocidadeAtual) : base(identificacao, capacidadeDePassageiros, modelo, velocidadeAtual)
        {
            Limpador = limpador;
            Voando = voando;
        }

        public string Decolar()
        {
            if (Voando)
                throw new Exception("O avião já está voando");
            else
            {
                Voando = true;
                return $"O {Tipo} {Identificacao} está Decolando...";
            }

        }

        public string Arremeter()
        {
            if (Voando)
            {
                Voando = false;
                return $"O {Tipo} {Identificacao} está arremetendo a decolagem";
            }
            else
            {
                Voando = true;
                return $"O {Tipo} {Identificacao} está arremetendo pouso";
            }
        }

        public string Pousar()
        {
            if (!Voando)
                throw new Exception("O avião não está voando");
            else
            {
                Voando = false;
                return $"O {Tipo} {Identificacao} está pousando...";
            }
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
