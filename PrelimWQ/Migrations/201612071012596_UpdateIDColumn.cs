namespace PrelimWQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateIDColumn : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Questionnaires", "id", "Id");

        }
        
        public override void Down()
        {
        }
    }
}
