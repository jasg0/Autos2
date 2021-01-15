namespace Autos.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartProject2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Carroes", "Fecha", c => c.DateTime(nullable: false));
            DropColumn("dbo.Carroes", "Tiempo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Carroes", "Tiempo", c => c.DateTime(nullable: false));
            DropColumn("dbo.Carroes", "Fecha");
        }
    }
}
