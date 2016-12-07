namespace PrelimWQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRemainingColumns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questionnaires", "C1_DOB", c => c.DateTime());
            AddColumn("dbo.Questionnaires", "C2", c => c.Int());
            AddColumn("dbo.Questionnaires", "C3", c => c.Int());
            AddColumn("dbo.Questionnaires", "C3_other", c => c.String());
            AddColumn("dbo.Questionnaires", "C4", c => c.Int());
            AddColumn("dbo.Questionnaires", "C5", c => c.Int());
            AddColumn("dbo.Questionnaires", "C6", c => c.Int());
            AddColumn("dbo.Questionnaires", "C7", c => c.Int());
            AddColumn("dbo.Questionnaires", "C8", c => c.Int());
            AddColumn("dbo.Questionnaires", "C9", c => c.Int());
            AddColumn("dbo.Questionnaires", "C_10a", c => c.Int());
            AddColumn("dbo.Questionnaires", "C_10b", c => c.Int());
            AddColumn("dbo.Questionnaires", "C_10c", c => c.Int());
            AddColumn("dbo.Questionnaires", "C_10d", c => c.Int());
            AddColumn("dbo.Questionnaires", "C_10e", c => c.Int());
            AddColumn("dbo.Questionnaires", "C_10f", c => c.Int());
            AddColumn("dbo.Questionnaires", "C11", c => c.Int());
            AddColumn("dbo.Questionnaires", "C12", c => c.String());
            AddColumn("dbo.Questionnaires", "C13", c => c.String());
            AddColumn("dbo.Questionnaires", "C14", c => c.String());
            AddColumn("dbo.Questionnaires", "C15", c => c.String());
            AddColumn("dbo.Questionnaires", "C16", c => c.Int());
            AddColumn("dbo.Questionnaires", "C17", c => c.Int());
            AddColumn("dbo.Questionnaires", "C18", c => c.Int());
            AddColumn("dbo.Questionnaires", "C19", c => c.Int());
            AddColumn("dbo.Questionnaires", "C20", c => c.Int());
            AddColumn("dbo.Questionnaires", "C21", c => c.Int());
            AddColumn("dbo.Questionnaires", "C22", c => c.Int());
            AddColumn("dbo.Questionnaires", "ConsentToMRR", c => c.Boolean());
            AddColumn("dbo.Questionnaires", "ConsentToHistoricStudies", c => c.Boolean());
            AddColumn("dbo.Questionnaires", "ConsentToFutureStudies", c => c.Boolean());
            AddColumn("dbo.Questionnaires", "DateOfSubmission", c => c.DateTime());
            AddColumn("dbo.Questionnaires", "Title", c => c.String());
            AddColumn("dbo.Questionnaires", "Forename", c => c.String());
            AddColumn("dbo.Questionnaires", "Surname", c => c.String());
            AddColumn("dbo.Questionnaires", "Address1", c => c.String());
            AddColumn("dbo.Questionnaires", "Address2", c => c.String());
            AddColumn("dbo.Questionnaires", "TownCity", c => c.String());
            AddColumn("dbo.Questionnaires", "County", c => c.String());
            AddColumn("dbo.Questionnaires", "Postcode", c => c.String());
            AddColumn("dbo.Questionnaires", "TelephoneNumber", c => c.String());
            AddColumn("dbo.Questionnaires", "SurveySubmitted", c => c.Boolean());
            AddColumn("dbo.Questionnaires", "StudyID", c => c.Int(nullable: false));
            AddColumn("dbo.Questionnaires", "SurveyStarted", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Questionnaires", "SurveyStarted");
            DropColumn("dbo.Questionnaires", "StudyID");
            DropColumn("dbo.Questionnaires", "SurveySubmitted");
            DropColumn("dbo.Questionnaires", "TelephoneNumber");
            DropColumn("dbo.Questionnaires", "Postcode");
            DropColumn("dbo.Questionnaires", "County");
            DropColumn("dbo.Questionnaires", "TownCity");
            DropColumn("dbo.Questionnaires", "Address2");
            DropColumn("dbo.Questionnaires", "Address1");
            DropColumn("dbo.Questionnaires", "Surname");
            DropColumn("dbo.Questionnaires", "Forename");
            DropColumn("dbo.Questionnaires", "Title");
            DropColumn("dbo.Questionnaires", "DateOfSubmission");
            DropColumn("dbo.Questionnaires", "ConsentToFutureStudies");
            DropColumn("dbo.Questionnaires", "ConsentToHistoricStudies");
            DropColumn("dbo.Questionnaires", "ConsentToMRR");
            DropColumn("dbo.Questionnaires", "C22");
            DropColumn("dbo.Questionnaires", "C21");
            DropColumn("dbo.Questionnaires", "C20");
            DropColumn("dbo.Questionnaires", "C19");
            DropColumn("dbo.Questionnaires", "C18");
            DropColumn("dbo.Questionnaires", "C17");
            DropColumn("dbo.Questionnaires", "C16");
            DropColumn("dbo.Questionnaires", "C15");
            DropColumn("dbo.Questionnaires", "C14");
            DropColumn("dbo.Questionnaires", "C13");
            DropColumn("dbo.Questionnaires", "C12");
            DropColumn("dbo.Questionnaires", "C11");
            DropColumn("dbo.Questionnaires", "C_10f");
            DropColumn("dbo.Questionnaires", "C_10e");
            DropColumn("dbo.Questionnaires", "C_10d");
            DropColumn("dbo.Questionnaires", "C_10c");
            DropColumn("dbo.Questionnaires", "C_10b");
            DropColumn("dbo.Questionnaires", "C_10a");
            DropColumn("dbo.Questionnaires", "C9");
            DropColumn("dbo.Questionnaires", "C8");
            DropColumn("dbo.Questionnaires", "C7");
            DropColumn("dbo.Questionnaires", "C6");
            DropColumn("dbo.Questionnaires", "C5");
            DropColumn("dbo.Questionnaires", "C4");
            DropColumn("dbo.Questionnaires", "C3_other");
            DropColumn("dbo.Questionnaires", "C3");
            DropColumn("dbo.Questionnaires", "C2");
            DropColumn("dbo.Questionnaires", "C1_DOB");
        }
    }
}
