namespace Dev69Restaurant.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase_remove_area : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TableFoods", "AreaId", "dbo.Areas");
            DropIndex("dbo.TableFoods", new[] { "AreaId" });
            DropColumn("dbo.TableFoods", "AreaId");
            DropTable("dbo.Areas");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.TableFoods", "AreaId", c => c.Int(nullable: false));
            CreateIndex("dbo.TableFoods", "AreaId");
            AddForeignKey("dbo.TableFoods", "AreaId", "dbo.Areas", "Id", cascadeDelete: true);
        }
    }
}
