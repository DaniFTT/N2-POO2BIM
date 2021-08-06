using N2_POO2BIM.Classes;
using N2_POO2BIM.Interfaces;
using System;

namespace N2_POO2BIM.Veiculos
{
    class AviaoDeGuerra : Veiculo, IAviao
    {
        public bool Voando { get; set; }
        public bool Piloto { get; private set; }
        public override string Tipo { get; protected set; } = "Avião de Guerra";
        public AviaoDeGuerra(
            bool voando,
            bool piloto,
            string identificacao,
            int capacidadeDePassageiros,
            Modelo modelo,
            int velocidadeAtual) : base(identificacao, capacidadeDePassageiros, modelo, velocidadeAtual)
        {
            Voando = voando;
            Piloto = piloto;
        }

        public string Decolar()
        {
            if (Piloto)
            {
                if (!Voando)
                {
                    Voando = true;
                    return $"O {Tipo} {Identificacao} está decolando..";
                }
                throw new Exception($"O {Tipo} {Identificacao} já está voando");
            }
            throw new Exception("Piloto foi ejetado");
        }

        public string Arremeter()
        {
            if (Piloto)
            {
                if (Voando)
                {
                    Voando = false;
                    return $"O {Tipo} {Identificacao} está Arremetendo decolagem.";
                }
                else
                {
                    Voando = true;
                    return $"O {Tipo} {Identificacao} está Arremetendo pouso.";
                }
            }           
            throw new Exception("Piloto foi ejetado.");
        }

        public string Pousar()
        {
            if (Piloto)
            {
                if (Voando)
                {
                    Voando = false;
                    return $"O {Tipo} {Identificacao} está pousando.";
                }               
                throw new Exception($"O {Tipo} não está voando");
            }
            throw new Exception("Piloto ejetado.");
        }
        public string Atacar()
        {
            if (!Piloto)
                throw new Exception("Piloto foi ejetado.");

            return $"O {Tipo} {Identificacao} está atacando!";          
        }
        public string Ejetar()
        {
            if (Piloto)
            {
                Piloto = false;
                return $"O piloto do {Tipo} {Identificacao} foi ejetado";
            }           
            throw new Exception("Piloto já foi ejetado.");
        }
    }
}
