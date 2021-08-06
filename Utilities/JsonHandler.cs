using N2_POO2BIM.Classes;
using N2_POO2BIM.Interfaces;
using N2_POO2BIM.Veiculos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO2BIM.Utilities
{
    public static class JsonHandler
    {
    
        private static StreamReader sr;

        #region Retornar Listas metodos
        public static List<Veiculo> ListaDeVeiculos()
        {
            List<Veiculo> veiculos = new List<Veiculo>(); 
            if (File.Exists(RetornaFilePath("Veiculos")))
            {
                sr = new StreamReader(RetornaFilePath("Veiculos"), true);

                string json = sr.ReadToEnd();
                sr.Dispose();

                if (json.Length < 1)
                {
                    return veiculos;
                }

                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                veiculos = JsonConvert.DeserializeObject<List<Veiculo>>(json, settings);
            }

            return veiculos;           
        }

        public static List<Marca> ListaDeMarcas()
        {
            List<Marca> marcas = new List<Marca>();
            if (File.Exists(RetornaFilePath("Marcas")))
            {
                sr = new StreamReader(RetornaFilePath("Marcas"), true);
                string json = sr.ReadToEnd();
                sr.Dispose();

                if (json.Length > 1)
                {
                    marcas = JsonConvert.DeserializeObject<List<Marca>>(json);
                }
            }

            return marcas;
        }

        public static List<Modelo> ListaDeModelos()
        {
            List<Modelo> modelos = new List<Modelo>();
            if (File.Exists(RetornaFilePath("Modelos")))
            {
                
                sr = new StreamReader(RetornaFilePath("Modelos"), true);
                string json = sr.ReadToEnd();

                sr.Dispose();

                if (json.Length > 1)
                {
                    modelos = JsonConvert.DeserializeObject<List<Modelo>>(json);
                }
            }

            return modelos;
        }

        public static List<Pedagio> ListaDePedagios()
        {
            List<Pedagio> pedagios = new List<Pedagio>();
            if (File.Exists(RetornaFilePath("Pedagios")))
            {
                sr = new StreamReader(RetornaFilePath("Pedagios"), true);
                string json = sr.ReadToEnd();

                sr.Dispose();



                if (json.Length > 1)
                {
                    pedagios = JsonConvert.DeserializeObject<List<Pedagio>>(json);
                }
            }
            return pedagios;
        }

        #endregion

        #region SalvarLista Metodos sobrecarregados
        public static void SalvarLista(List<Veiculo> veiculos)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            string conteudo = JsonConvert.SerializeObject(veiculos, Formatting.Indented, settings);
            File.WriteAllText($"{Environment.CurrentDirectory}\\filesJson\\Veiculos.json", conteudo, Encoding.UTF8);
        }
        public static void SalvarLista(List<Marca> marcas)
        {
            var json = JsonConvert.SerializeObject(marcas, Formatting.Indented);
            File.WriteAllText(RetornaFilePath("Marcas"), json);
        }
        public static void SalvarLista(List<Modelo> modelos)
        {
            var json = JsonConvert.SerializeObject(modelos, Formatting.Indented);
            File.WriteAllText(RetornaFilePath("Modelos"), json);
        }
        public static void SalvarLista(List<Pedagio> pedagios)
        {
            var json = JsonConvert.SerializeObject(pedagios, Formatting.Indented);
            File.WriteAllText(RetornaFilePath("Pedagios"), json);
        }
        #endregion

        public static string RetornaFilePath(string arquivo)
        {
            return $"{Environment.CurrentDirectory}\\filesJson\\{arquivo}.json";
        }
    }
}
