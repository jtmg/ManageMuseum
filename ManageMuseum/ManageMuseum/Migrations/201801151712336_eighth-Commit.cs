namespace ManageMuseum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eighthCommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Spaces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Area = c.Double(nullable: false),
                        Local = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SpaceEvents",
                c => new
                    {
                        Space_Id = c.Int(nullable: false),
                        Event_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Space_Id, t.Event_Id })
                .ForeignKey("dbo.Spaces", t => t.Space_Id, cascadeDelete: true)
                .ForeignKey("dbo.Events", t => t.Event_Id, cascadeDelete: true)
                .Index(t => t.Space_Id)
                .Index(t => t.Event_Id);
            
            AddColumn("dbo.ArtPieces", "State", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SpaceEvents", "Event_Id", "dbo.Events");
            DropForeignKey("dbo.SpaceEvents", "Space_Id", "dbo.Spaces");
            DropIndex("dbo.SpaceEvents", new[] { "Event_Id" });
            DropIndex("dbo.SpaceEvents", new[] { "Space_Id" });
            DropColumn("dbo.ArtPieces", "State");
            DropTable("dbo.SpaceEvents");
            DropTable("dbo.Spaces");
        }
    }
}
