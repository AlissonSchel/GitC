namespace WebMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarroAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Placa = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        UsuInc = c.Int(nullable: false),
                        UsuAlt = c.Int(nullable: false),
                        DatInc = c.DateTime(nullable: false),
                        DatAlt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Carroes");
        }
    }
}
