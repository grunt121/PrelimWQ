namespace PrelimWQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUnneededColumns : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Questionnaires", "ConsentToMRR");
            DropColumn("dbo.Questionnaires", "ConsentToHistoricStudies");
            DropColumn("dbo.Questionnaires", "ConsentToFutureStudies");
            DropColumn("dbo.Questionnaires", "DateOfSubmission");
            DropColumn("dbo.Questionnaires", "Title");
            DropColumn("dbo.Questionnaires", "Forename");
            DropColumn("dbo.Questionnaires", "Surname");
            DropColumn("dbo.Questionnaires", "Address1");
            DropColumn("dbo.Questionnaires", "Address2");
            DropColumn("dbo.Questionnaires", "TownCity");
            DropColumn("dbo.Questionnaires", "County");
            DropColumn("dbo.Questionnaires", "Postcode");
            DropColumn("dbo.Questionnaires", "TelephoneNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questionnaires", "TelephoneNumber", c => c.String());
            AddColumn("dbo.Questionnaires", "Postcode", c => c.String());
            AddColumn("dbo.Questionnaires", "County", c => c.String());
            AddColumn("dbo.Questionnaires", "TownCity", c => c.String());
            AddColumn("dbo.Questionnaires", "Address2", c => c.String());
            AddColumn("dbo.Questionnaires", "Address1", c => c.String());
            AddColumn("dbo.Questionnaires", "Surname", c => c.String());
            AddColumn("dbo.Questionnaires", "Forename", c => c.String());
            AddColumn("dbo.Questionnaires", "Title", c => c.String());
            AddColumn("dbo.Questionnaires", "DateOfSubmission", c => c.DateTime());
            AddColumn("dbo.Questionnaires", "ConsentToFutureStudies", c => c.Int());
            AddColumn("dbo.Questionnaires", "ConsentToHistoricStudies", c => c.Int());
            AddColumn("dbo.Questionnaires", "ConsentToMRR", c => c.Int());
        }
    }
}
