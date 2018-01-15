namespace ManageMuseum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourthCommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EnDate = c.DateTime(nullable: false),
                        Name = c.String(),
                        EventType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Events");
        }
    }
}
