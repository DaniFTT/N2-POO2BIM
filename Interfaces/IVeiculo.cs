using N2_POO2BIM.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO2BIM.Interfaces
{
    public interface IVeiculo
    {
        Modelo Modelo { get; set; }

        int VelocidadeAtual { get; }

        string Tipo { get; }
        string Identificacao { get; }

        int CapacidadeDePassageiros { get; }

        string Acelerar();

        string Desacelerar();
    }
}
