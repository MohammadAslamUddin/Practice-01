namespace Practice_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingForeignKey1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "CourseId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "CourseId");
            AddForeignKey("dbo.Students", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
            DropColumn("dbo.Courses", "StudentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "StudentId", c => c.Int());
            DropForeignKey("dbo.Students", "CourseId", "dbo.Courses");
            DropIndex("dbo.Students", new[] { "CourseId" });
            DropColumn("dbo.Students", "CourseId");
        }
    }
}
