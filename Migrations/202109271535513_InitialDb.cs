namespace Dev69Restaurant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BillDetails",
                c => new
                    {
                        BillId = c.Int(nullable: false),
                        FoodId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        DateCheckin = c.DateTime(nullable: false),
                        DateCheckout = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.BillId, t.FoodId })
                .ForeignKey("dbo.Bills", t => t.BillId, cascadeDelete: true)
                .ForeignKey("dbo.Foods", t => t.FoodId, cascadeDelete: true)
                .Index(t => t.BillId)
                .Index(t => t.FoodId);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerCategoryId = c.Int(nullable: false),
                        TableId = c.Int(nullable: false),
                        VATId = c.Int(nullable: false),
                        PaymentMethod = c.String(),
                        DiscountCode = c.String(maxLength: 10),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CustomerCategories", t => t.CustomerCategoryId, cascadeDelete: true)
                .ForeignKey("dbo.TableFoods", t => t.TableId, cascadeDelete: true)
                .ForeignKey("dbo.VATs", t => t.VATId, cascadeDelete: true)
                .Index(t => t.CustomerCategoryId)
                .Index(t => t.TableId)
                .Index(t => t.VATId);
            
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
            
            CreateTable(
                "dbo.TableFoods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        AreaId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Areas", t => t.AreaId, cascadeDelete: true)
                .Index(t => t.AreaId);
            
            CreateTable(
                "dbo.VATs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TaxPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TaxPercent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PromotionPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CategoryId = c.Int(nullable: false),
                        Image = c.String(maxLength: 256),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FoodCategories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.FoodCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 256),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CustomerCategories", t => t.CustomerCategoryId, cascadeDelete: true)
                .Index(t => t.CustomerCategoryId);
            
            CreateTable(
                "dbo.Discounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Code = c.String(nullable: false, maxLength: 10, unicode: false),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        DiscountPercent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ConditionPrice = c.Decimal(precision: 18, scale: 2),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(),
                        UpdatedBy = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 128),
                        DisplayName = c.String(maxLength: 256),
                        FullName = c.String(nullable: false, maxLength: 256),
                        BirthDay = c.DateTime(),
                        Address = c.String(maxLength: 256),
                        Phone = c.String(maxLength: 20, unicode: false),
                        Email = c.String(maxLength: 256),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "CustomerCategoryId", "dbo.CustomerCategories");
            DropForeignKey("dbo.BillDetails", "FoodId", "dbo.Foods");
            DropForeignKey("dbo.Foods", "CategoryId", "dbo.FoodCategories");
            DropForeignKey("dbo.BillDetails", "BillId", "dbo.Bills");
            DropForeignKey("dbo.Bills", "VATId", "dbo.VATs");
            DropForeignKey("dbo.Bills", "TableId", "dbo.TableFoods");
            DropForeignKey("dbo.TableFoods", "AreaId", "dbo.Areas");
            DropForeignKey("dbo.Bills", "CustomerCategoryId", "dbo.CustomerCategories");
            DropIndex("dbo.Customers", new[] { "CustomerCategoryId" });
            DropIndex("dbo.Foods", new[] { "CategoryId" });
            DropIndex("dbo.TableFoods", new[] { "AreaId" });
            DropIndex("dbo.Bills", new[] { "VATId" });
            DropIndex("dbo.Bills", new[] { "TableId" });
            DropIndex("dbo.Bills", new[] { "CustomerCategoryId" });
            DropIndex("dbo.BillDetails", new[] { "FoodId" });
            DropIndex("dbo.BillDetails", new[] { "BillId" });
            DropTable("dbo.Users");
            DropTable("dbo.Discounts");
            DropTable("dbo.Customers");
            DropTable("dbo.FoodCategories");
            DropTable("dbo.Foods");
            DropTable("dbo.VATs");
            DropTable("dbo.TableFoods");
            DropTable("dbo.CustomerCategories");
            DropTable("dbo.Bills");
            DropTable("dbo.BillDetails");
            DropTable("dbo.Areas");
        }
    }
}
