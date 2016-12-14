namespace PrelimWQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateColumnB9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questionnaires", "B9", c => c.Int());
            DropColumn("dbo.Questionnaires", "B_9");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questionnaires", "B_9", c => c.Int());
            DropColumn("dbo.Questionnaires", "B9");
        }
    }
}
