using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO2BIM.Classes
{
    public class Marca
    {
        private int codigo;
        private string descricao;

        public int Codigo

        {
            get => codigo;
            set
            {
                if (value < 1)
                    throw new Exception("O código não pode ser menor ou igual a 0.");

                codigo = value;
            }
        }

        public string Descricao
        {
            get => descricao;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A descrição é obrigatória.");

                descricao = value;
            }
        }

        public Marca(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }
    }
}
