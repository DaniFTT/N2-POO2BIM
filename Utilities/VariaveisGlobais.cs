using N2_POO2BIM.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO2BIM.Utilities
{
    public class VariaveisGlobais
    {


        public string RetornaFilePath(string arquivo)
        {
            return $"{Environment.CurrentDirectory}\\filesJson\\{arquivo}.json";
        }
    }
}
