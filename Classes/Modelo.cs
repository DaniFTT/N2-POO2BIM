using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO2BIM.Classes
{
    public class Modelo
    {
        private int codigo;
        private string descricao;

        public int Codigo
        {
            get => codigo;
            set
            {
                if (value < 0)
                    throw new Exception("Valor de código inválido.");

                codigo = value;
            }
        }

        public string Descricao
        {
            get => descricao;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Valor de descrição vazio.");

                descricao = value;
            }
        }

        public Marca Marca { get; private set; }

        public Modelo(int codigo, string descricao, Marca marca)
        {
            Codigo = codigo;
            Descricao = descricao;
            Marca = marca;
        }
    }
}
