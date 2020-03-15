using ClinicaVeterinaria.ModelPoco;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.Data
{
    public class VeterinarioMap : EntityTypeConfiguration<Veterinario>
    {
        public VeterinarioMap()
        {
            this.ToTable("Veterinario");
            this.HasKey(v => v.Id);
            this.Property(v => v.Id).HasColumnName("ID_VETERINARIO");
            this.Property(v => v.Nome).HasColumnName("NOME_VETERINARIO");
            this.Property(v => v.Especialidade).HasColumnName("ESPECIALIDADE_VETERINARIO");
            this.Property(v => v.DataNascimento).HasColumnName("DATANASCIEMENTO_VETERINARIO");
            this.Property(v => v.Localizacao).HasColumnName("LOCALIZACAO_VETERINARIO");
            this.Property(v => v.Cpf).HasColumnName("CPF_VETERINARIO");
            this.Property(v => v.Crmv).HasColumnName("CRMV_VETERINARIO");
        }
    }
}
