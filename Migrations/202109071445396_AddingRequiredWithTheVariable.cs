namespace Practice_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingRequiredWithTheVariable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Contact", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Address", c => c.String());
            AlterColumn("dbo.Students", "Contact", c => c.String());
            AlterColumn("dbo.Students", "Email", c => c.String());
            AlterColumn("dbo.Students", "Name", c => c.String());
            DropColumn("dbo.Students", "Date");
        }
    }
}
