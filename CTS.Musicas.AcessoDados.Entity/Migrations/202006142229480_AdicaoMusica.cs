namespace CTS.Musicas.AcessoDados.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicaoMusica : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MUS_MUSICAS",
                c => new
                    {
                        MUS_ID = c.Long(nullable: false, identity: true),
                        MUS_NOME = c.String(nullable: false, maxLength: 50),
                        ALB_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MUS_ID)
                .ForeignKey("dbo.ALB_ALBUNS", t => t.ALB_ID, cascadeDelete: true)
                .Index(t => t.ALB_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MUS_MUSICAS", "ALB_ID", "dbo.ALB_ALBUNS");
            DropIndex("dbo.MUS_MUSICAS", new[] { "ALB_ID" });
            DropTable("dbo.MUS_MUSICAS");
        }
    }
}
