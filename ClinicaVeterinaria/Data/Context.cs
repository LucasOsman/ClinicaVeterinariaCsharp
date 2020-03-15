using ClinicaVeterinaria.ModelPoco;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.Data
{
    public class Context : DbContext
    {
        public Context() : base("Server=LUCAS; Database=projeto;Integrated Security=True;") { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Atendimento> Atendimentos { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<Context>(null);
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new AtendimentoMap());
            modelBuilder.Configurations.Add(new VeterinarioMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
