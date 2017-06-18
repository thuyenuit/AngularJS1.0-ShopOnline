namespace ShopOnline.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Footers",
                c => new
                    {
                        FooterID = c.Int(nullable: false, identity: true),
                        FooterContent = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FooterID);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        MenuID = c.Int(nullable: false, identity: true),
                        MenuName = c.String(nullable: false, maxLength: 100),
                        MenuURL = c.String(nullable: false, maxLength: 255),
                        MenuDisplayOrder = c.Int(),
                        MenuGroupID = c.Int(nullable: false),
                        MenuTarget = c.String(),
                        MenuStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MenuID)
                .ForeignKey("dbo.MenuGroups", t => t.MenuGroupID, cascadeDelete: true)
                .Index(t => t.MenuGroupID);
            
            CreateTable(
                "dbo.MenuGroups",
                c => new
                    {
                        MenuGroupID = c.Int(nullable: false, identity: true),
                        MenuGroupName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MenuGroupID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        OrderCustomerName = c.String(nullable: false, maxLength: 100),
                        OrderCustomerAddress = c.String(nullable: false, maxLength: 255),
                        OrderCustomerPhone = c.String(nullable: false, maxLength: 20),
                        OrderCustomerEmail = c.String(maxLength: 100),
                        OrderCustomerMessage = c.String(maxLength: 255),
                        OrderPayment = c.String(maxLength: 255),
                        OrderCreateDate = c.DateTime(),
                        OrderCreateBy = c.String(maxLength: 100),
                        OrderPaymentStatus = c.String(maxLength: 100),
                        OrderStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        OrderDetailQuantity = c.Int(nullable: false),
                        OrderDetailPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.OrderID, t.ProductID })
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.OrderID, cascadeDelete: true)
                .Index(t => t.OrderID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 255),
                        ProductAlias = c.String(nullable: false, maxLength: 255, unicode: false),
                        ProductCategoryID = c.Int(nullable: false),
                        ProductImage = c.String(maxLength: 500),
                        ProductMoreImage = c.String(storeType: "xml"),
                        ProductPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductPromotionPrice = c.Decimal(precision: 18, scale: 2),
                        ProductWarranty = c.Int(),
                        ProductQuantity = c.Int(),
                        ProductDescription = c.String(maxLength: 255),
                        ProductContent = c.String(maxLength: 500),
                        ProductHomeFlag = c.Boolean(),
                        ProductHotFlag = c.Boolean(),
                        ProductViewCount = c.Int(),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 255),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 255),
                        MetaKeyword = c.String(maxLength: 500),
                        MetaDescription = c.String(maxLength: 500),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.ProductCategories", t => t.ProductCategoryID, cascadeDelete: true)
                .Index(t => t.ProductCategoryID);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        ProductCatgoryID = c.Int(nullable: false, identity: true),
                        ProductCatgoryName = c.String(nullable: false, maxLength: 255),
                        ProductCatgoryAlias = c.String(nullable: false, maxLength: 255),
                        ProductCatgoryDescription = c.String(maxLength: 255),
                        ProductCatgoryParentID = c.Int(),
                        ProductCatgoryDisplayOrder = c.Int(),
                        ProductCatgoryImage = c.String(),
                        ProductCatgoryHomeFlag = c.Boolean(),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 255),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 255),
                        MetaKeyword = c.String(maxLength: 500),
                        MetaDescription = c.String(maxLength: 500),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductCatgoryID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostsID = c.Int(nullable: false, identity: true),
                        PostsName = c.String(nullable: false, maxLength: 255),
                        PostsAlias = c.String(nullable: false, maxLength: 255, unicode: false),
                        PostsCategoryID = c.Int(nullable: false),
                        PostsImage = c.String(maxLength: 255),
                        PostsDescription = c.String(maxLength: 500),
                        PostsContent = c.String(),
                        PostsHomeFlag = c.Boolean(),
                        PostsHotFlag = c.Boolean(),
                        PostsViewCount = c.Int(),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 255),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 255),
                        MetaKeyword = c.String(maxLength: 500),
                        MetaDescription = c.String(maxLength: 500),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PostsID)
                .ForeignKey("dbo.PostCategories", t => t.PostsCategoryID, cascadeDelete: true)
                .Index(t => t.PostsCategoryID);
            
            CreateTable(
                "dbo.PostCategories",
                c => new
                    {
                        PostCategoryID = c.Int(nullable: false, identity: true),
                        PostCategoryName = c.String(nullable: false, maxLength: 255),
                        PostCategoryAlias = c.String(nullable: false, maxLength: 255, unicode: false),
                        PostCategoryDescription = c.String(maxLength: 255),
                        PostCategoryParentID = c.Int(),
                        PostCategoryDisplayOrder = c.Int(),
                        PostCategoryImage = c.String(),
                        PostCategoryHomeFlag = c.Boolean(),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 255),
                        UpdateDate = c.DateTime(),
                        UpdateBy = c.String(maxLength: 255),
                        MetaKeyword = c.String(maxLength: 500),
                        MetaDescription = c.String(maxLength: 500),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PostCategoryID);
            
            CreateTable(
                "dbo.ProductTags",
                c => new
                    {
                        ProductID = c.Int(nullable: false),
                        TagID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductID, t.TagID })
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.TagID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.TagID);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        TagID = c.Int(nullable: false, identity: true),
                        TagName = c.String(nullable: false, maxLength: 100),
                        TagType = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.TagID);
            
            CreateTable(
                "dbo.Slides",
                c => new
                    {
                        SlideID = c.Int(nullable: false, identity: true),
                        SlideName = c.String(nullable: false, maxLength: 100),
                        SlideDescription = c.String(maxLength: 255),
                        SlideImage = c.String(maxLength: 500),
                        SlideUrl = c.String(maxLength: 256),
                        SlideDisplayOrder = c.Int(),
                        SlideStatus = c.Boolean(nullable: false),
                        SlideContent = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.SlideID);
            
            CreateTable(
                "dbo.SystemConfigs",
                c => new
                    {
                        SystemConfigID = c.Int(nullable: false, identity: true),
                        SystemConfigContent = c.String(nullable: false, maxLength: 255),
                        SystemConfigStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SystemConfigID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductTags", "TagID", "dbo.Tags");
            DropForeignKey("dbo.ProductTags", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Posts", "PostsCategoryID", "dbo.PostCategories");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Products");
            DropForeignKey("dbo.Products", "ProductCategoryID", "dbo.ProductCategories");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Menus", "MenuGroupID", "dbo.MenuGroups");
            DropIndex("dbo.ProductTags", new[] { "TagID" });
            DropIndex("dbo.ProductTags", new[] { "ProductID" });
            DropIndex("dbo.Posts", new[] { "PostsCategoryID" });
            DropIndex("dbo.Products", new[] { "ProductCategoryID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.Menus", new[] { "MenuGroupID" });
            DropTable("dbo.SystemConfigs");
            DropTable("dbo.Slides");
            DropTable("dbo.Tags");
            DropTable("dbo.ProductTags");
            DropTable("dbo.PostCategories");
            DropTable("dbo.Posts");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Products");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Orders");
            DropTable("dbo.MenuGroups");
            DropTable("dbo.Menus");
            DropTable("dbo.Footers");
        }
    }
}
