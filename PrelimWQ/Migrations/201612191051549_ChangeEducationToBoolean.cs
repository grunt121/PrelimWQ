namespace PrelimWQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeEducationToBoolean : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Questionnaires", "C6_a", c => c.Boolean());
            AlterColumn("dbo.Questionnaires", "C6_b", c => c.Boolean());
            AlterColumn("dbo.Questionnaires", "C6_c", c => c.Boolean());
            AlterColumn("dbo.Questionnaires", "C6_d", c => c.Boolean());
            AlterColumn("dbo.Questionnaires", "C6_e", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Questionnaires", "C6_e", c => c.Int());
            AlterColumn("dbo.Questionnaires", "C6_d", c => c.Int());
            AlterColumn("dbo.Questionnaires", "C6_c", c => c.Int());
            AlterColumn("dbo.Questionnaires", "C6_b", c => c.Int());
            AlterColumn("dbo.Questionnaires", "C6_a", c => c.Int());
        }
    }
}
