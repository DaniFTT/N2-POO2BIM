using N2_POO2BIM.Classes;
using N2_POO2BIM.Interfaces;
using System;

namespace N2_POO2BIM.Veiculos
{
    class NavioDeGuerra : Veiculo, INavio
    {
        public bool Atracado { get; private set; }

        public override string Tipo { get; protected set; } = "Navio de Guerra";
        public NavioDeGuerra(
           string identificacao,
           int capacidadeDePassageiros,
           Modelo modelo,
           int velocidadeAtual) : base(identificacao, capacidadeDePassageiros, modelo, velocidadeAtual)
        {
            Atracado = false;
        }

        public string Atracar()
        {
            if (Atracado)
                throw new Exception($"O {Tipo} {Identificacao } já está atracado.");
            else
            {
                Atracado = true;
                return $"O {Tipo} {Identificacao} está atracando..";
            }
        }

        public string Atacar()
        {
            return $"O {Tipo} {Identificacao} está atacando!";
        }
    }
}
