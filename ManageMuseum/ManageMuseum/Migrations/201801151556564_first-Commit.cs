namespace ManageMuseum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstCommit : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserAccounts");
        }
    }
}
