namespace ManageMuseum.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sixthCommit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ArtPieces", "Year", c => c.DateTime(nullable: false));
            AddColumn("dbo.ArtPieces", "Catalog_Id", c => c.Int());
            CreateIndex("dbo.ArtPieces", "Catalog_Id");
            AddForeignKey("dbo.ArtPieces", "Catalog_Id", "dbo.Catalogs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArtPieces", "Catalog_Id", "dbo.Catalogs");
            DropIndex("dbo.ArtPieces", new[] { "Catalog_Id" });
            DropColumn("dbo.ArtPieces", "Catalog_Id");
            DropColumn("dbo.ArtPieces", "Year");
        }
    }
}
