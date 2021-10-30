namespace Dev69Restaurant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDb : DbMigration
    {
        public override void Up()
        {
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
                        TableId = c.Int(nullable: false),
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
                .ForeignKey("dbo.TableFoods", t => t.TableId, cascadeDelete: true)
                .Index(t => t.TableId);
            
            CreateTable(
                "dbo.TableFoods",
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
                "dbo.Foods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
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
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ShortName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Username, cascadeDelete: true)
                .Index(t => t.Username)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 128),
                        DisplayName = c.String(maxLength: 256),
                        FullName = c.String(nullable: false, maxLength: 256),
                        Avatar = c.String(maxLength: 256),
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
            DropForeignKey("dbo.UserRoles", "Username", "dbo.Users");
            DropForeignKey("dbo.UserRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.BillDetails", "FoodId", "dbo.Foods");
            DropForeignKey("dbo.Foods", "CategoryId", "dbo.FoodCategories");
            DropForeignKey("dbo.BillDetails", "BillId", "dbo.Bills");
            DropForeignKey("dbo.Bills", "TableId", "dbo.TableFoods");
            DropIndex("dbo.UserRoles", new[] { "RoleId" });
            DropIndex("dbo.UserRoles", new[] { "Username" });
            DropIndex("dbo.Foods", new[] { "CategoryId" });
            DropIndex("dbo.Bills", new[] { "TableId" });
            DropIndex("dbo.BillDetails", new[] { "FoodId" });
            DropIndex("dbo.BillDetails", new[] { "BillId" });
            DropTable("dbo.Users");
            DropTable("dbo.UserRoles");
            DropTable("dbo.Roles");
            DropTable("dbo.Discounts");
            DropTable("dbo.FoodCategories");
            DropTable("dbo.Foods");
            DropTable("dbo.TableFoods");
            DropTable("dbo.Bills");
            DropTable("dbo.BillDetails");
        }
    }
}
