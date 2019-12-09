namespace BaithiASP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeDatabase : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Exams");
            AddColumn("dbo.Exams", "ExamId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Exams", "ExamTime", c => c.DateTime(nullable: false, precision: 0));
            AddColumn("dbo.Exams", "Room", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Exams", "ExamSubject", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.Exams", "ExamDuration", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.Exams", "Faculty", c => c.String(nullable: false, unicode: false));
            AddPrimaryKey("dbo.Exams", "ExamId");
            DropColumn("dbo.Exams", "Id");
            DropColumn("dbo.Exams", "ClassRoom");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Exams", "ClassRoom", c => c.Int(nullable: false));
            AddColumn("dbo.Exams", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Exams");
            AlterColumn("dbo.Exams", "Faculty", c => c.Int(nullable: false));
            AlterColumn("dbo.Exams", "ExamDuration", c => c.Int(nullable: false));
            AlterColumn("dbo.Exams", "ExamSubject", c => c.Int(nullable: false));
            DropColumn("dbo.Exams", "Room");
            DropColumn("dbo.Exams", "ExamTime");
            DropColumn("dbo.Exams", "ExamId");
            AddPrimaryKey("dbo.Exams", "Id");
        }
    }
}
