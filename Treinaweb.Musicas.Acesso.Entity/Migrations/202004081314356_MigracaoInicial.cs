namespace Treinaweb.Musicas.Acesso.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracaoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ALB_ALBUNS",
                c => new
                    {
                        ALB_ID = c.Int(nullable: false, identity: true),
                        ABL_NOME = c.String(nullable: false, maxLength: 100),
                        ABL_ANO = c.Int(nullable: false),
                        ABL_OBSERVACOES = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.ALB_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ALB_ALBUNS");
        }
    }
}
