using ClinicaVeterinaria.ModelPoco;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;


namespace ClinicaVeterinaria.Data
{
    public class AtendimentoMap : EntityTypeConfiguration<Atendimento>
    {

        public AtendimentoMap()
        {
            this.ToTable("Atendimento");
            this.HasKey(a => a.Id);
            this.Property(a => a.Id).HasColumnName("ID_ATENDIMENTO");
            this.Property(a => a.Cliente).HasColumnName("CLIENTE_ATENDIMENTO");
            this.Property(a => a.Veterinario).HasColumnName("VETERINARIO_ATENDIMENTO");
            this.Property(a => a.DataAtendimento).HasColumnName("DATAATENDIMENTO_ATENDIMENTO");
            this.Property(a => a.DataInicio).HasColumnName("DATAINICIO_ATENDIMENTO");
            this.Property(a => a.DataFim).HasColumnName("DATAFIM_ATENDIMENTO");
            this.Property(a => a.Localizacao).HasColumnName("LOCALIZACAO_ATENDIMENTO");
        }
    }
}
