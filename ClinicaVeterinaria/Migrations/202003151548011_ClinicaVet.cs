namespace ClinicaVeterinaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClinicaVet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Atendimento",
                c => new
                    {
                        ID_ATENDIMENTO = c.Int(nullable: false, identity: true),
                        Cliente = c.String(),
                        VETERINARIO_ATENDIMENTO = c.String(),
                        LOCALIZACAO_ATENDIMENTO = c.String(),
                        DATAINICIO_ATENDIMENTO = c.DateTime(nullable: false),
                        DATAFIM_ATENDIMENTO = c.DateTime(nullable: false),
                        DataAtendimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID_ATENDIMENTO);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ID_CLEINTE = c.Int(nullable: false, identity: true),
                        NOME_CLIENTE = c.String(),
                        CPF_CLIENTE = c.Int(nullable: false),
                        DATANASCIMENTO_CLIENTE = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID_CLEINTE);
            
            CreateTable(
                "dbo.Veterinario",
                c => new
                    {
                        ID_VETERINARIO = c.Int(nullable: false, identity: true),
                        NOME_VETERINARIO = c.String(),
                        CPF_VETERINARIO = c.Int(nullable: false),
                        CRMV_VETERINARIO = c.Int(nullable: false),
                        DATANASCIEMENTO_VETERINARIO = c.DateTime(nullable: false),
                        Especialidade = c.String(),
                        LOCALIZACAO_VETERINARIO = c.String(),
                    })
                .PrimaryKey(t => t.ID_VETERINARIO);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Veterinario");
            DropTable("dbo.Cliente");
            DropTable("dbo.Atendimento");
        }
    }
}
