namespace PostGreSql.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userischanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Age", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "CurrentOffice", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "CurrentOffice");
            DropColumn("dbo.AspNetUsers", "Age");
        }
    }
}
