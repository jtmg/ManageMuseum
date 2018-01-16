namespace ManageMuseum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1st : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArtPieces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Dimension = c.Double(nullable: false),
                        Year = c.DateTime(nullable: false),
                        Author = c.String(),
                        State = c.String(),
                        RoomMuseum_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RoomMuseums", t => t.RoomMuseum_Id)
                .Index(t => t.RoomMuseum_Id);
            
            CreateTable(
                "dbo.RoomMuseums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Area = c.Double(nullable: false),
                        Floor = c.Int(nullable: false),
                        Event_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.Event_Id)
                .Index(t => t.Event_Id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EnDate = c.DateTime(nullable: false),
                        Name = c.String(),
                        EventType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EventTypes", t => t.EventType_Id)
                .Index(t => t.EventType_Id);
            
            CreateTable(
                "dbo.EventRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Event_Id = c.Int(),
                        UserAccount_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.Event_Id)
                .ForeignKey("dbo.UserAccounts", t => t.UserAccount_Id)
                .Index(t => t.Event_Id)
                .Index(t => t.UserAccount_Id);
            
            CreateTable(
                "dbo.UserAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(),
                        Role_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.Role_Id)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EventTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OutSideSpaces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Event_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.Event_Id)
                .Index(t => t.Event_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoomMuseums", "Event_Id", "dbo.Events");
            DropForeignKey("dbo.OutSideSpaces", "Event_Id", "dbo.Events");
            DropForeignKey("dbo.Events", "EventType_Id", "dbo.EventTypes");
            DropForeignKey("dbo.UserAccounts", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.EventRequests", "UserAccount_Id", "dbo.UserAccounts");
            DropForeignKey("dbo.EventRequests", "Event_Id", "dbo.Events");
            DropForeignKey("dbo.ArtPieces", "RoomMuseum_Id", "dbo.RoomMuseums");
            DropIndex("dbo.OutSideSpaces", new[] { "Event_Id" });
            DropIndex("dbo.UserAccounts", new[] { "Role_Id" });
            DropIndex("dbo.EventRequests", new[] { "UserAccount_Id" });
            DropIndex("dbo.EventRequests", new[] { "Event_Id" });
            DropIndex("dbo.Events", new[] { "EventType_Id" });
            DropIndex("dbo.RoomMuseums", new[] { "Event_Id" });
            DropIndex("dbo.ArtPieces", new[] { "RoomMuseum_Id" });
            DropTable("dbo.OutSideSpaces");
            DropTable("dbo.EventTypes");
            DropTable("dbo.Roles");
            DropTable("dbo.UserAccounts");
            DropTable("dbo.EventRequests");
            DropTable("dbo.Events");
            DropTable("dbo.RoomMuseums");
            DropTable("dbo.ArtPieces");
        }
    }
}
