namespace Treinaweb.Musicas.Acesso.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicaoMusica : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Musicas",
                c => new
                    {
                        Mus_Id = c.Long(nullable: false, identity: true),
                        Mus_Nome = c.String(nullable: false, maxLength: 50),
                        ALB_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Mus_Id)
                .ForeignKey("dbo.ALB_ALBUNS", t => t.ALB_Id, cascadeDelete: true)
                .Index(t => t.ALB_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Musicas", "ALB_Id", "dbo.ALB_ALBUNS");
            DropIndex("dbo.Musicas", new[] { "ALB_Id" });
            DropTable("dbo.Musicas");
        }
    }
}
