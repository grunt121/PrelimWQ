namespace PrelimWQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResetTablesFor5000 : DbMigration
    {
        public override void Up()
        {

            Sql("DELETE FROM dbo.Exports");

            Sql("DELETE FROM dbo.AspNetUsers");

        }
        
        public override void Down()
        {
        }
    }
}
