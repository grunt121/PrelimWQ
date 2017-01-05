namespace PrelimWQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveStudyIDAspNetUsers : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "StudyId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "StudyId", c => c.Int());
        }
    }
}
