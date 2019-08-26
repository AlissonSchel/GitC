namespace WebApiInsano.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixNumFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Rg", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Clientes", "CpfCnpj", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "CpfCnpj", c => c.Int(nullable: false));
            AlterColumn("dbo.Clientes", "Rg", c => c.Int(nullable: false));
        }
    }
}
