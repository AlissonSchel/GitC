namespace WebApiInsano.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "NomeFantasia", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Clientes", "Email", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "Email", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "NomeFantasia", c => c.Int(nullable: false));
        }
    }
}
