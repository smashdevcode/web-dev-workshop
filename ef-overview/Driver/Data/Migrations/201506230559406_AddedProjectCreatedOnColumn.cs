namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProjectCreatedOnColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "CreatedOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "CreatedOn");
        }
    }
}
