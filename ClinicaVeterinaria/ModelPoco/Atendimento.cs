using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.ModelPoco
{
    public class Atendimento
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string Veterinario { get; set; }
        public string Localizacao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime DataAtendimento { get; set; }
    }
}
