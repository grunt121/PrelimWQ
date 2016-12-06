namespace PrelimWQ.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateColumnsAB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questionnaires", "A_1b", c => c.Int());
            AddColumn("dbo.Questionnaires", "A_1c", c => c.Int());
            AddColumn("dbo.Questionnaires", "A1_d", c => c.Int());
            AddColumn("dbo.Questionnaires", "A1_e", c => c.Int());
            AddColumn("dbo.Questionnaires", "A_1_health", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_1", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_2", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_3a", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_3b", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_3c", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_3d", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_3e", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_3f", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_3g", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_3h", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_3i", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_3j", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_4a", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_4b", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_4c", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_4d", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_4e", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_4f", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_4g", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_4h", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_4i", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_4j", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_5", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_6", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_7", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_8", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_9", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_10", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_11", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_12", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_13", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_14", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_15", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_16", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_17", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_18", c => c.Int());
            AddColumn("dbo.Questionnaires", "A2_19", c => c.Int());
            AddColumn("dbo.Questionnaires", "A3_1a", c => c.Int());
            AddColumn("dbo.Questionnaires", "A3_1b", c => c.Int());
            AddColumn("dbo.Questionnaires", "A3_1c", c => c.Int());
            AddColumn("dbo.Questionnaires", "A3_1d", c => c.Int());
            AddColumn("dbo.Questionnaires", "A3_1e", c => c.Int());
            AddColumn("dbo.Questionnaires", "A3_2a", c => c.Int());
            AddColumn("dbo.Questionnaires", "A3_2b", c => c.Int());
            AddColumn("dbo.Questionnaires", "A3_2c", c => c.Int());
            AddColumn("dbo.Questionnaires", "A3_2d", c => c.Int());
            AddColumn("dbo.Questionnaires", "A3_2e", c => c.Int());
            AddColumn("dbo.Questionnaires", "A3_2f", c => c.Int());
            AddColumn("dbo.Questionnaires", "A3_2f_other", c => c.String());
            AddColumn("dbo.Questionnaires", "A4_1", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_2", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_3", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_4", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_5", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_6", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_7", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_8", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_9a", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_9b", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_9c", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_9d", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_10a", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_10b", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_10c", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_10d", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_11a", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_11b", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_11c", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_11d", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_12a", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_12b", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_12c", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_12d", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_12e", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_12f", c => c.Int());
            AddColumn("dbo.Questionnaires", "A4_12g", c => c.Int());
            AddColumn("dbo.Questionnaires", "A5_1", c => c.Int());
            AddColumn("dbo.Questionnaires", "A5_2", c => c.Int());
            AddColumn("dbo.Questionnaires", "A5_3", c => c.Int());
            AddColumn("dbo.Questionnaires", "A5_4", c => c.Int());
            AddColumn("dbo.Questionnaires", "A5_5", c => c.Int());
            AddColumn("dbo.Questionnaires", "A5_6", c => c.Int());
            AddColumn("dbo.Questionnaires", "A5_7", c => c.Int());
            AddColumn("dbo.Questionnaires", "A5_8", c => c.Int());
            AddColumn("dbo.Questionnaires", "A5_9", c => c.Int());
            AddColumn("dbo.Questionnaires", "A5_10", c => c.Int());
            AddColumn("dbo.Questionnaires", "A5_11", c => c.Int());
            AddColumn("dbo.Questionnaires", "A5_12", c => c.Int());
            AddColumn("dbo.Questionnaires", "A5_13", c => c.Int());
            AddColumn("dbo.Questionnaires", "A5_14", c => c.Int());
            AddColumn("dbo.Questionnaires", "B1_stones", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Questionnaires", "B1_llbs", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Questionnaires", "B1_kgs", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Questionnaires", "B2_feet", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Questionnaires", "B2_inches", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Questionnaires", "B2_cms", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Questionnaires", "B3", c => c.Int());
            AddColumn("dbo.Questionnaires", "B4", c => c.Int());
            AddColumn("dbo.Questionnaires", "B5_a", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Questionnaires", "B5_b", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Questionnaires", "B5_c", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Questionnaires", "B6", c => c.Int());
            AddColumn("dbo.Questionnaires", "B7", c => c.Int());
            AddColumn("dbo.Questionnaires", "B_8a", c => c.Int());
            AddColumn("dbo.Questionnaires", "B_8b", c => c.Int());
            AddColumn("dbo.Questionnaires", "B_8c", c => c.Int());
            AddColumn("dbo.Questionnaires", "B_8d", c => c.Int());
            AddColumn("dbo.Questionnaires", "B_8e", c => c.Int());
            AddColumn("dbo.Questionnaires", "B_9", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Questionnaires", "B_9");
            DropColumn("dbo.Questionnaires", "B_8e");
            DropColumn("dbo.Questionnaires", "B_8d");
            DropColumn("dbo.Questionnaires", "B_8c");
            DropColumn("dbo.Questionnaires", "B_8b");
            DropColumn("dbo.Questionnaires", "B_8a");
            DropColumn("dbo.Questionnaires", "B7");
            DropColumn("dbo.Questionnaires", "B6");
            DropColumn("dbo.Questionnaires", "B5_c");
            DropColumn("dbo.Questionnaires", "B5_b");
            DropColumn("dbo.Questionnaires", "B5_a");
            DropColumn("dbo.Questionnaires", "B4");
            DropColumn("dbo.Questionnaires", "B3");
            DropColumn("dbo.Questionnaires", "B2_cms");
            DropColumn("dbo.Questionnaires", "B2_inches");
            DropColumn("dbo.Questionnaires", "B2_feet");
            DropColumn("dbo.Questionnaires", "B1_kgs");
            DropColumn("dbo.Questionnaires", "B1_llbs");
            DropColumn("dbo.Questionnaires", "B1_stones");
            DropColumn("dbo.Questionnaires", "A5_14");
            DropColumn("dbo.Questionnaires", "A5_13");
            DropColumn("dbo.Questionnaires", "A5_12");
            DropColumn("dbo.Questionnaires", "A5_11");
            DropColumn("dbo.Questionnaires", "A5_10");
            DropColumn("dbo.Questionnaires", "A5_9");
            DropColumn("dbo.Questionnaires", "A5_8");
            DropColumn("dbo.Questionnaires", "A5_7");
            DropColumn("dbo.Questionnaires", "A5_6");
            DropColumn("dbo.Questionnaires", "A5_5");
            DropColumn("dbo.Questionnaires", "A5_4");
            DropColumn("dbo.Questionnaires", "A5_3");
            DropColumn("dbo.Questionnaires", "A5_2");
            DropColumn("dbo.Questionnaires", "A5_1");
            DropColumn("dbo.Questionnaires", "A4_12g");
            DropColumn("dbo.Questionnaires", "A4_12f");
            DropColumn("dbo.Questionnaires", "A4_12e");
            DropColumn("dbo.Questionnaires", "A4_12d");
            DropColumn("dbo.Questionnaires", "A4_12c");
            DropColumn("dbo.Questionnaires", "A4_12b");
            DropColumn("dbo.Questionnaires", "A4_12a");
            DropColumn("dbo.Questionnaires", "A4_11d");
            DropColumn("dbo.Questionnaires", "A4_11c");
            DropColumn("dbo.Questionnaires", "A4_11b");
            DropColumn("dbo.Questionnaires", "A4_11a");
            DropColumn("dbo.Questionnaires", "A4_10d");
            DropColumn("dbo.Questionnaires", "A4_10c");
            DropColumn("dbo.Questionnaires", "A4_10b");
            DropColumn("dbo.Questionnaires", "A4_10a");
            DropColumn("dbo.Questionnaires", "A4_9d");
            DropColumn("dbo.Questionnaires", "A4_9c");
            DropColumn("dbo.Questionnaires", "A4_9b");
            DropColumn("dbo.Questionnaires", "A4_9a");
            DropColumn("dbo.Questionnaires", "A4_8");
            DropColumn("dbo.Questionnaires", "A4_7");
            DropColumn("dbo.Questionnaires", "A4_6");
            DropColumn("dbo.Questionnaires", "A4_5");
            DropColumn("dbo.Questionnaires", "A4_4");
            DropColumn("dbo.Questionnaires", "A4_3");
            DropColumn("dbo.Questionnaires", "A4_2");
            DropColumn("dbo.Questionnaires", "A4_1");
            DropColumn("dbo.Questionnaires", "A3_2f_other");
            DropColumn("dbo.Questionnaires", "A3_2f");
            DropColumn("dbo.Questionnaires", "A3_2e");
            DropColumn("dbo.Questionnaires", "A3_2d");
            DropColumn("dbo.Questionnaires", "A3_2c");
            DropColumn("dbo.Questionnaires", "A3_2b");
            DropColumn("dbo.Questionnaires", "A3_2a");
            DropColumn("dbo.Questionnaires", "A3_1e");
            DropColumn("dbo.Questionnaires", "A3_1d");
            DropColumn("dbo.Questionnaires", "A3_1c");
            DropColumn("dbo.Questionnaires", "A3_1b");
            DropColumn("dbo.Questionnaires", "A3_1a");
            DropColumn("dbo.Questionnaires", "A2_19");
            DropColumn("dbo.Questionnaires", "A2_18");
            DropColumn("dbo.Questionnaires", "A2_17");
            DropColumn("dbo.Questionnaires", "A2_16");
            DropColumn("dbo.Questionnaires", "A2_15");
            DropColumn("dbo.Questionnaires", "A2_14");
            DropColumn("dbo.Questionnaires", "A2_13");
            DropColumn("dbo.Questionnaires", "A2_12");
            DropColumn("dbo.Questionnaires", "A2_11");
            DropColumn("dbo.Questionnaires", "A2_10");
            DropColumn("dbo.Questionnaires", "A2_9");
            DropColumn("dbo.Questionnaires", "A2_8");
            DropColumn("dbo.Questionnaires", "A2_7");
            DropColumn("dbo.Questionnaires", "A2_6");
            DropColumn("dbo.Questionnaires", "A2_5");
            DropColumn("dbo.Questionnaires", "A2_4j");
            DropColumn("dbo.Questionnaires", "A2_4i");
            DropColumn("dbo.Questionnaires", "A2_4h");
            DropColumn("dbo.Questionnaires", "A2_4g");
            DropColumn("dbo.Questionnaires", "A2_4f");
            DropColumn("dbo.Questionnaires", "A2_4e");
            DropColumn("dbo.Questionnaires", "A2_4d");
            DropColumn("dbo.Questionnaires", "A2_4c");
            DropColumn("dbo.Questionnaires", "A2_4b");
            DropColumn("dbo.Questionnaires", "A2_4a");
            DropColumn("dbo.Questionnaires", "A2_3j");
            DropColumn("dbo.Questionnaires", "A2_3i");
            DropColumn("dbo.Questionnaires", "A2_3h");
            DropColumn("dbo.Questionnaires", "A2_3g");
            DropColumn("dbo.Questionnaires", "A2_3f");
            DropColumn("dbo.Questionnaires", "A2_3e");
            DropColumn("dbo.Questionnaires", "A2_3d");
            DropColumn("dbo.Questionnaires", "A2_3c");
            DropColumn("dbo.Questionnaires", "A2_3b");
            DropColumn("dbo.Questionnaires", "A2_3a");
            DropColumn("dbo.Questionnaires", "A2_2");
            DropColumn("dbo.Questionnaires", "A2_1");
            DropColumn("dbo.Questionnaires", "A_1_health");
            DropColumn("dbo.Questionnaires", "A1_e");
            DropColumn("dbo.Questionnaires", "A1_d");
            DropColumn("dbo.Questionnaires", "A_1c");
            DropColumn("dbo.Questionnaires", "A_1b");
        }
    }
}