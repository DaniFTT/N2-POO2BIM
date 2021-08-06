using N2_POO2BIM.Classes;
using N2_POO2BIM.Interfaces;
using System;

namespace N2_POO2BIM.Veiculos
{
    class Caminhao : Veiculo, ILimpador, IPagaPedagio
    {
        private double pesoCarregado;
        private int quantidadeDeEixos;
        private double capacidadeMaxima;

        public bool PodeAcelerar { get; private set; }
        public bool Limpador { get; private set; }
        public override string Tipo { get; protected set; } = "Caminhão";
        public double PesoCarregado
        {
            get => pesoCarregado;
            set
            {
                if ((pesoCarregado + value >= capacidadeMaxima) && value > 0)
                {
                    pesoCarregado = pesoCarregado + value; 
                    PodeAcelerar = false;
                    throw new Exception($"O Caminhão {Identificacao} atingiu sua capacidade máxima de peso, e por tanto não poderá acelerar!" +
                        $"\nCapacidade máxima: {capacidadeMaxima}" +
                        $"\nPeso Atual: {pesoCarregado}");
                }
                else if (value > 0)
                    pesoCarregado = pesoCarregado + value;
                else
                    pesoCarregado = 0.00;
            }
        }
        public int QuantidadeDeEixos
        {
            get => quantidadeDeEixos;
            set
            {
                if (value < 3)
                    throw new Exception($"A quantidade de eixos do {Tipo} não pode ser menor ou igual a zero!");

                quantidadeDeEixos = value;
            }
        }
        public double CapacidadeMaxima
        {
            get => capacidadeMaxima;
            set
            {
                if (value <= 0.00)
                    throw new Exception($"A capacidade máxima do {Tipo} não pode ser menor ou igual a zero!");

                capacidadeMaxima = value;
            }
        }
        public Caminhao(
            int quantidadeDeEixos,
            double capacidadeMaxima,
            bool limpador,
            bool podeAcelerar,
            double pesoCarregado,
            string identificacao,
            int capacidadeDePassageiros,
            Modelo modelo,
            int velocidadeAtual) : base(identificacao, capacidadeDePassageiros, modelo, velocidadeAtual)
        {
            QuantidadeDeEixos = quantidadeDeEixos;
            CapacidadeMaxima = capacidadeMaxima;
            PodeAcelerar = podeAcelerar;
            PesoCarregado = pesoCarregado;
            Limpador = limpador;
        }
        public override string Acelerar()
        {
            if (!PodeAcelerar)
                throw new Exception($"O {Tipo} {Identificacao} atingiu sua capacidade máxima, portanto não pode acelerar até que seja descarregado!");

            return base.Acelerar();
        }
        public string Carregar(double peso)
        {
            if (peso <= 0)
                throw new Exception("A carga não pode ser menor ou igual a zero!");
            else
            {
                PesoCarregado = peso;
                return $"O {Identificacao} foi Carregado com {peso}Kg... Carga Atual: {PesoCarregado}Kg";
            }
        }
        public string Descarregar()
        {
            PesoCarregado = 0.00;
            PodeAcelerar = true;
            return $"O {Identificacao} foi totalmente Descarregado!";
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
