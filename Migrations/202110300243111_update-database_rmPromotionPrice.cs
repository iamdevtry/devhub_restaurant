namespace Dev69Restaurant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase_rmPromotionPrice : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Foods", "PromotionPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Foods", "PromotionPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
