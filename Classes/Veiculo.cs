using N2_POO2BIM.Interfaces;
using System;

namespace N2_POO2BIM.Classes
{
    public abstract class Veiculo
    {
        private string identificacao;
        private int capacidadeDePassageiros;

        public Modelo Modelo { get; set; }
        public int VelocidadeAtual { get; private set; } = 0;
        public virtual string Tipo { get; protected set; } 
        public string InfoVeiculo => $"{Identificacao} -- {Modelo.Descricao}/{Tipo}";

        public string Identificacao
        {
            get => identificacao;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Valor de identificação vazio.");

                identificacao = value;
            }
        }

        public int CapacidadeDePassageiros
        {
            get => capacidadeDePassageiros;
            set
            {
                if (value < 1)
                    throw new Exception("Capacidade de passageiros deve ser maior que 0");

                capacidadeDePassageiros = value;
            }
        }

        protected Veiculo(string identificacao, int capacidadeDePassageiros, Modelo modelo, int velocidadeAtual)
        {
            Identificacao = identificacao;
            CapacidadeDePassageiros = capacidadeDePassageiros;
            Modelo = modelo;
            VelocidadeAtual = velocidadeAtual;
        }

        public virtual string Acelerar()
        {
            VelocidadeAtual++;
            return $"O {Tipo} {identificacao} Acelerou... Vel Atual: {VelocidadeAtual} Km/h";
        }

        public string Desacelerar()
        {
            if (VelocidadeAtual > 0)
            {
                VelocidadeAtual--;
                return $"O {Tipo} {identificacao} desacelerou... Vel Atual: {VelocidadeAtual} Km/h";
            }  
            
            throw new Exception($"O {Tipo} {identificacao} atingiu velocidade 0!\nNão é possivel Desacelerar!");
        }
    }
}
