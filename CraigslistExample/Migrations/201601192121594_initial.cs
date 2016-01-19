namespace CraigslistExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Listings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Pictures = c.String(),
                        ListingCategory_Id = c.Int(),
                        Owner_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.ListingCategory_Id)
                .ForeignKey("dbo.Users", t => t.Owner_Id)
                .Index(t => t.ListingCategory_Id)
                .Index(t => t.Owner_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Listings", "Owner_Id", "dbo.Users");
            DropForeignKey("dbo.Listings", "ListingCategory_Id", "dbo.Categories");
            DropIndex("dbo.Listings", new[] { "Owner_Id" });
            DropIndex("dbo.Listings", new[] { "ListingCategory_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Listings");
            DropTable("dbo.Categories");
        }
    }
}
