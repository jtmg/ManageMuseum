namespace ManageMuseum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMig : DbMigration
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
                        IdCatalog_Id = c.Int(),
                        IdRoomMuseum_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Catalogs", t => t.IdCatalog_Id)
                .ForeignKey("dbo.RoomMuseums", t => t.IdRoomMuseum_Id)
                .Index(t => t.IdCatalog_Id)
                .Index(t => t.IdRoomMuseum_Id);
            
            CreateTable(
                "dbo.Catalogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RoomMuseums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Area = c.Double(nullable: false),
                        Floor = c.Int(nullable: false),
                        IdEvent_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.IdEvent_Id)
                .Index(t => t.IdEvent_Id);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EnDate = c.DateTime(nullable: false),
                        Name = c.String(),
                        IdEventType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EventTypes", t => t.IdEventType_Id)
                .Index(t => t.IdEventType_Id);
            
            CreateTable(
                "dbo.EventRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdEvent_Id = c.Int(),
                        IdUserAccount_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.IdEvent_Id)
                .ForeignKey("dbo.UserAccounts", t => t.IdUserAccount_Id)
                .Index(t => t.IdEvent_Id)
                .Index(t => t.IdUserAccount_Id);
            
            CreateTable(
                "dbo.UserAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Role = c.String(),
                        ConfirmPassword = c.String(),
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
                        IdEvent_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.IdEvent_Id)
                .Index(t => t.IdEvent_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoomMuseums", "IdEvent_Id", "dbo.Events");
            DropForeignKey("dbo.OutSideSpaces", "IdEvent_Id", "dbo.Events");
            DropForeignKey("dbo.Events", "IdEventType_Id", "dbo.EventTypes");
            DropForeignKey("dbo.EventRequests", "IdUserAccount_Id", "dbo.UserAccounts");
            DropForeignKey("dbo.EventRequests", "IdEvent_Id", "dbo.Events");
            DropForeignKey("dbo.ArtPieces", "IdRoomMuseum_Id", "dbo.RoomMuseums");
            DropForeignKey("dbo.ArtPieces", "IdCatalog_Id", "dbo.Catalogs");
            DropIndex("dbo.OutSideSpaces", new[] { "IdEvent_Id" });
            DropIndex("dbo.EventRequests", new[] { "IdUserAccount_Id" });
            DropIndex("dbo.EventRequests", new[] { "IdEvent_Id" });
            DropIndex("dbo.Events", new[] { "IdEventType_Id" });
            DropIndex("dbo.RoomMuseums", new[] { "IdEvent_Id" });
            DropIndex("dbo.ArtPieces", new[] { "IdRoomMuseum_Id" });
            DropIndex("dbo.ArtPieces", new[] { "IdCatalog_Id" });
            DropTable("dbo.OutSideSpaces");
            DropTable("dbo.EventTypes");
            DropTable("dbo.UserAccounts");
            DropTable("dbo.EventRequests");
            DropTable("dbo.Events");
            DropTable("dbo.RoomMuseums");
            DropTable("dbo.Catalogs");
            DropTable("dbo.ArtPieces");
        }
    }
}
