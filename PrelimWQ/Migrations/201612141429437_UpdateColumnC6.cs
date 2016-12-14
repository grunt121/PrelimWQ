namespace PrelimWQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateColumnC6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questionnaires", "C6_a", c => c.Int());
            AddColumn("dbo.Questionnaires", "C6_b", c => c.Int());
            AddColumn("dbo.Questionnaires", "C6_c", c => c.Int());
            AddColumn("dbo.Questionnaires", "C6_d", c => c.Int());
            AddColumn("dbo.Questionnaires", "C6_e", c => c.Int());
            DropColumn("dbo.Questionnaires", "C6");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Questionnaires", "C6", c => c.Int());
            DropColumn("dbo.Questionnaires", "C6_e");
            DropColumn("dbo.Questionnaires", "C6_d");
            DropColumn("dbo.Questionnaires", "C6_c");
            DropColumn("dbo.Questionnaires", "C6_b");
            DropColumn("dbo.Questionnaires", "C6_a");
        }
    }
}
