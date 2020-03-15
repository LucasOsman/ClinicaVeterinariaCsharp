using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.ModelPoco
{
    public class Veterinario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public int Crmv { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Especialidade { get; set; }
        public string Localizacao { get; set; }
    }
}
