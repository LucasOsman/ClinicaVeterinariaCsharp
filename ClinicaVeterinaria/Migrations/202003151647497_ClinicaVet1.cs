namespace ClinicaVeterinaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClinicaVet1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Atendimento", name: "Cliente", newName: "CLIENTE_ATENDIMENTO");
            RenameColumn(table: "dbo.Atendimento", name: "DataAtendimento", newName: "DATAATENDIMENTO_ATENDIMENTO");
            RenameColumn(table: "dbo.Veterinario", name: "Especialidade", newName: "ESPECIALIDADE_VETERINARIO");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Veterinario", name: "ESPECIALIDADE_VETERINARIO", newName: "Especialidade");
            RenameColumn(table: "dbo.Atendimento", name: "DATAATENDIMENTO_ATENDIMENTO", newName: "DataAtendimento");
            RenameColumn(table: "dbo.Atendimento", name: "CLIENTE_ATENDIMENTO", newName: "Cliente");
        }
    }
}
