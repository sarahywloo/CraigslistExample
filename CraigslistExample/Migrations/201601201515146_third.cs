namespace CraigslistExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Listings", name: "ListingCategory_Id", newName: "Category_Id");
            RenameIndex(table: "dbo.Listings", name: "IX_ListingCategory_Id", newName: "IX_Category_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Listings", name: "IX_Category_Id", newName: "IX_ListingCategory_Id");
            RenameColumn(table: "dbo.Listings", name: "Category_Id", newName: "ListingCategory_Id");
        }
    }
}
