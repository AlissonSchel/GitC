namespace WebMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pulsao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoas", "Ativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pessoas", "UsuInc", c => c.Int(nullable: false));
            AddColumn("dbo.Pessoas", "UsuAlt", c => c.Int(nullable: false));
            AddColumn("dbo.Pessoas", "DatInc", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pessoas", "DatAlt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pessoas", "DatAlt");
            DropColumn("dbo.Pessoas", "DatInc");
            DropColumn("dbo.Pessoas", "UsuAlt");
            DropColumn("dbo.Pessoas", "UsuInc");
            DropColumn("dbo.Pessoas", "Ativo");
        }
    }
}
