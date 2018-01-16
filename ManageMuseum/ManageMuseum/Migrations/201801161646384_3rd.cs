namespace ManageMuseum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3rd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventStates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Events", "EventState_Id", c => c.Int());
            CreateIndex("dbo.Events", "EventState_Id");
            AddForeignKey("dbo.Events", "EventState_Id", "dbo.EventStates", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "EventState_Id", "dbo.EventStates");
            DropIndex("dbo.Events", new[] { "EventState_Id" });
            DropColumn("dbo.Events", "EventState_Id");
            DropTable("dbo.EventStates");
        }
    }
}
