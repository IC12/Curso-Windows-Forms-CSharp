using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWinFormsBiblioteca.Classes
{
    public class Cep
    {
        public class Unit
        {
            public string cep { get; set; }
            public string logradouro { get; set; }
            public string complemento { get; set; }
            public string bairro { get; set; }
            public string localidade { get; set; }
            public string uf { get; set; }
            public string ibge { get; set; }
            public string gia { get; set; }
            public string ddd { get; set; }
            public string siafi { get; set; }
        }

        public static Unit DesSerializedClass(string vJson)
        {
            return JsonConvert.DeserializeObject<Unit>(vJson);
        }

        public static string SerializedClass(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }
    }
}
