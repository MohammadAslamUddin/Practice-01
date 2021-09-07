namespace Practice_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingForeignKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Student_Id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "Student_Id");
        }
    }
}
