namespace BookShelf.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Price");
        }
    }
}
