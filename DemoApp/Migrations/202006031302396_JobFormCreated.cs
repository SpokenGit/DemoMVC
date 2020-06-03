namespace DemoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JobFormCreated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Jobs", "JobTitle", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Jobs", "JobDescription", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Jobs", "JobDescription", c => c.String(maxLength: 200));
            AlterColumn("dbo.Jobs", "JobTitle", c => c.String(maxLength: 100));
        }
    }
}
