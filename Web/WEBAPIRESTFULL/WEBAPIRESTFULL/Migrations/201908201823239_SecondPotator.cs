namespace WEBAPIRESTFULL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondPotator : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locacao", "Potator", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locacao", "Potator");
        }
    }
}
