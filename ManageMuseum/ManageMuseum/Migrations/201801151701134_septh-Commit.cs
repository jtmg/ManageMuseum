namespace ManageMuseum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class septhCommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserAccountEvents",
                c => new
                    {
                        UserAccount_Id = c.Int(nullable: false),
                        Event_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserAccount_Id, t.Event_Id })
                .ForeignKey("dbo.UserAccounts", t => t.UserAccount_Id, cascadeDelete: true)
                .ForeignKey("dbo.Events", t => t.Event_Id, cascadeDelete: true)
                .Index(t => t.UserAccount_Id)
                .Index(t => t.Event_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserAccountEvents", "Event_Id", "dbo.Events");
            DropForeignKey("dbo.UserAccountEvents", "UserAccount_Id", "dbo.UserAccounts");
            DropIndex("dbo.UserAccountEvents", new[] { "Event_Id" });
            DropIndex("dbo.UserAccountEvents", new[] { "UserAccount_Id" });
            DropTable("dbo.UserAccountEvents");
        }
    }
}
