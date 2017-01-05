namespace PrelimWQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResetSeed : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM dbo.Exports");

            Sql("DELETE FROM dbo.AspNetUsers");        

            Sql("DELETE FROM dbo.Questionnaires");
            Sql("DBCC CHECKIDENT('dbo.Questionnaires', RESEED, 0)");

        }
        
        public override void Down()
        {
        }
    }
}
