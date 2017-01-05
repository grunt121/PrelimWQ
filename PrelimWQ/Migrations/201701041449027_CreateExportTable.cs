namespace PrelimWQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateExportTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudyId = c.Int(),
                        OnlineIdLogin = c.String(),
                        OnlineIdPassword = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Exports");
        }
    }
}
