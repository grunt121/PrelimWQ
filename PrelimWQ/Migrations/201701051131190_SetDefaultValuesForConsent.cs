namespace PrelimWQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetDefaultValuesForConsent : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Questionnaires ADD CONSTRAINT DefaultConsetMRR DEFAULT 0 FOR ConsentToMRR");
            Sql("ALTER TABLE Questionnaires ADD CONSTRAINT DefaultConsetHistoric DEFAULT 0 FOR ConsentToHistoricStudies");
            Sql("ALTER TABLE Questionnaires ADD CONSTRAINT DefaultConsetFuture DEFAULT 0 FOR ConsentToFutureStudies");
        }
        
        public override void Down()
        {
        }
    }
}
