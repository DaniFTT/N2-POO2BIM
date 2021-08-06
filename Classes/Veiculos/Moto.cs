using N2_POO2BIM.Classes;
using N2_POO2BIM.Interfaces;

namespace N2_POO2BIM.Veiculos
{
    class Moto : Veiculo, IPagaPedagio
    {
        public override string Tipo { get; protected set; } = "Moto";

        public Moto(
            string identificacao,
            int capacidadeDePassageiros,
            Modelo modelo,
            int velocidadeAtual) : base(identificacao, capacidadeDePassageiros, modelo, velocidadeAtual) { }

        public string Empinar()
        {
            return $"A {Tipo} {Identificacao} está empinando";
        }

        public double PagaPedagio()
        {
            return 3.00;
        }
    }
}
