namespace ManageMuseum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3rd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserAccounts", "FirstName", c => c.String());
            AlterColumn("dbo.UserAccounts", "LastName", c => c.String());
            AlterColumn("dbo.UserAccounts", "Username", c => c.String());
            AlterColumn("dbo.UserAccounts", "Password", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserAccounts", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.UserAccounts", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.UserAccounts", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.UserAccounts", "FirstName", c => c.String(nullable: false));
        }
    }
}
