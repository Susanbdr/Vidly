namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedTheName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberShipTypes", "Name", c => c.String());
            DropColumn("dbo.MemberShipTypes", "MemberShipTypes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MemberShipTypes", "MemberShipTypes", c => c.String());
            DropColumn("dbo.MemberShipTypes", "Name");
        }
    }
}
