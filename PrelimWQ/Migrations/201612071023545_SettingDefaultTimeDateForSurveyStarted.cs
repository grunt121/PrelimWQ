namespace PrelimWQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SettingDefaultTimeDateForSurveyStarted : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Questionnaires ADD CONSTRAINT FirstSaveForSurvey DEFAULT GETDATE() FOR SurveyStarted");
        }
        
        public override void Down()
        {
        }
    }
}
