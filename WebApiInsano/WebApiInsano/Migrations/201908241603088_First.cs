namespace WebApiInsano.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeCompleto = c.String(maxLength: 4000),
                        EstadoCivil = c.String(maxLength: 4000),
                        Rg = c.Int(nullable: false),
                        CpfCnpj = c.Int(nullable: false),
                        NomeFantasia = c.Int(nullable: false),
                        Cep = c.Int(nullable: false),
                        Endereco = c.String(maxLength: 4000),
                        Cidade = c.String(maxLength: 4000),
                        Estado = c.String(maxLength: 4000),
                        Telefone = c.Int(nullable: false),
                        Celular = c.Int(nullable: false),
                        Email = c.Int(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
