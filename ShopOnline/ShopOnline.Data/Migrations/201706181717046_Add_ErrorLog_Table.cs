namespace ShopOnline.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_ErrorLog_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ErrorLogs",
                c => new
                    {
                        ErrorLogID = c.Int(nullable: false, identity: true),
                        ErrorLogMessage = c.String(),
                        ErrorLogStackTrace = c.String(),
                        ErrorLogCreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ErrorLogID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ErrorLogs");
        }
    }
}
