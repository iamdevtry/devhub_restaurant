namespace Dev69Restaurant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedbv2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bills", "CustomerCategoryId", "dbo.CustomerCategories");
            DropForeignKey("dbo.Customers", "CustomerCategoryId", "dbo.CustomerCategories");
            DropIndex("dbo.Bills", new[] { "CustomerCategoryId" });
            DropIndex("dbo.Customers", new[] { "CustomerCategoryId" });
            DropColumn("dbo.Bills", "CustomerCategoryId");
            DropTable("dbo.CustomerCategories");
            DropTable("dbo.Customers");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Address = c.String(maxLength: 256),
                        Phone = c.String(maxLength: 20, unicode: false),
                        CustomerCategoryId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomerCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Bills", "CustomerCategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "CustomerCategoryId");
            CreateIndex("dbo.Bills", "CustomerCategoryId");
            AddForeignKey("dbo.Customers", "CustomerCategoryId", "dbo.CustomerCategories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Bills", "CustomerCategoryId", "dbo.CustomerCategories", "Id", cascadeDelete: true);
        }
    }
}
