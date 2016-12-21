namespace PrelimWQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStudyIDColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "StudyId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "StudyId");
        }
    }
}
