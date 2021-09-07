namespace Practice_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStudentTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "StudentId", c => c.Int());
            DropColumn("dbo.Courses", "Student_Id");


            Sql(@"UPDATE dbo.Course SET StudentId = 1
              where StudentId IS NULL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "Student_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Courses", "StudentId");
        }
    }
}
