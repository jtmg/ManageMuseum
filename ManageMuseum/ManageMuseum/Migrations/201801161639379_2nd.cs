namespace ManageMuseum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2nd : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EventRequests", "Event_Id", "dbo.Events");
            DropIndex("dbo.EventRequests", new[] { "Event_Id" });
            DropIndex("dbo.EventRequests", new[] { "UserAccount_Id" });
            AddColumn("dbo.Events", "UserAccount_Id", c => c.Int());
            CreateIndex("dbo.Events", "UserAccount_Id");
            DropTable("dbo.EventRequests");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EventRequests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Event_Id = c.Int(),
                        UserAccount_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropIndex("dbo.Events", new[] { "UserAccount_Id" });
            DropColumn("dbo.Events", "UserAccount_Id");
            CreateIndex("dbo.EventRequests", "UserAccount_Id");
            CreateIndex("dbo.EventRequests", "Event_Id");
            AddForeignKey("dbo.EventRequests", "Event_Id", "dbo.Events", "Id");
        }
    }
}
