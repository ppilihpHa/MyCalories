namespace MyCalories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gerichts",
                c => new
                    {
                        GerichtId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        kal = c.Single(nullable: false),
                        eiw = c.Single(nullable: false),
                        menge = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.GerichtId);
            
            CreateTable(
                "dbo.GerichtZutats",
                c => new
                    {
                        GerichtZutatId = c.Int(nullable: false, identity: true),
                        GerichtId = c.Int(nullable: false),
                        ZutatId = c.Int(nullable: false),
                        menge = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GerichtZutatId)
                .ForeignKey("dbo.Gerichts", t => t.GerichtId, cascadeDelete: true)
                .ForeignKey("dbo.Zutats", t => t.ZutatId, cascadeDelete: true)
                .Index(t => t.GerichtId)
                .Index(t => t.ZutatId);
            
            CreateTable(
                "dbo.Zutats",
                c => new
                    {
                        ZutatId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        eiweiß = c.Single(nullable: false),
                        kalorien = c.Single(nullable: false),
                        gewicht = c.Int(nullable: false),
                        kategorie = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ZutatId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        TagId = c.Int(nullable: false, identity: true),
                        Zeitpunkt = c.DateTime(nullable: false),
                        TagZuCal = c.Single(nullable: false),
                        TagZuEiw = c.Single(nullable: false),
                        TagZuMenge = c.Single(nullable: false),
                        ZutatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TagId)
                .ForeignKey("dbo.Zutats", t => t.ZutatId, cascadeDelete: true)
                .Index(t => t.ZutatId);
            
            CreateTable(
                "dbo.Solls",
                c => new
                    {
                        SollId = c.Int(nullable: false, identity: true),
                        sollKalorien = c.Int(nullable: false),
                        sollEiweiß = c.Int(nullable: false),
                        datum = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SollId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GerichtZutats", "ZutatId", "dbo.Zutats");
            DropForeignKey("dbo.Tags", "ZutatId", "dbo.Zutats");
            DropForeignKey("dbo.GerichtZutats", "GerichtId", "dbo.Gerichts");
            DropIndex("dbo.Tags", new[] { "ZutatId" });
            DropIndex("dbo.GerichtZutats", new[] { "ZutatId" });
            DropIndex("dbo.GerichtZutats", new[] { "GerichtId" });
            DropTable("dbo.Solls");
            DropTable("dbo.Tags");
            DropTable("dbo.Zutats");
            DropTable("dbo.GerichtZutats");
            DropTable("dbo.Gerichts");
        }
    }
}
