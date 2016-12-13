namespace PrelimWQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMigrationFromBitToNumeric : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Questionnaires", "ConsentToMRR", c => c.Int());
            AlterColumn("dbo.Questionnaires", "ConsentToHistoricStudies", c => c.Int());
            AlterColumn("dbo.Questionnaires", "ConsentToFutureStudies", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Questionnaires", "ConsentToFutureStudies", c => c.Boolean());
            AlterColumn("dbo.Questionnaires", "ConsentToHistoricStudies", c => c.Boolean());
            AlterColumn("dbo.Questionnaires", "ConsentToMRR", c => c.Boolean());
        }
    }
}
