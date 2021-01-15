namespace Autos.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartProject1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marca = c.String(),
                        Modelo = c.String(),
                        Año = c.Int(nullable: false),
                        Combustible = c.String(),
                        Color = c.String(),
                        Precio = c.Double(nullable: false),
                        Tiempo = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Carroes");
        }
    }
}
