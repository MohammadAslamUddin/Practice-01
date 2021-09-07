namespace Practice_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakingUniqueCours : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Courses", "Code", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Courses", new[] { "Code" });
        }
    }
}
