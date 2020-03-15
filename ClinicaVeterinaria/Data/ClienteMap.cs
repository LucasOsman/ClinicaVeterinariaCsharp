using ClinicaVeterinaria.ModelPoco;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicaVeterinaria.Data
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {

        public ClienteMap ()
        {
            this.ToTable("Cliente");
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasColumnName("ID_CLEINTE");
            this.Property(c => c.Nome).HasColumnName("NOME_CLIENTE");
            this.Property(c => c.Cpf).HasColumnName("CPF_CLIENTE");
            this.Property(c => c.DataNascimento).HasColumnName("DATANASCIMENTO_CLIENTE");
        }
    }
}
