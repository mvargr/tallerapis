namespace TallerAPI.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Publicaciones",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        usuario = c.String(),
                        descripcion = c.String(),
                        fechapublicacion = c.DateTime(nullable: false),
                        megusta = c.Int(nullable: false),
                        medisgusta = c.Int(nullable: false),
                        vecescompartido = c.Int(nullable: false),
                        esprivada = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Publicaciones");
        }
    }
}
