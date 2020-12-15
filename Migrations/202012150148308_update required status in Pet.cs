namespace PetZen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updaterequiredstatusinPet : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pets", "Weight", c => c.Double());
            AlterColumn("dbo.Pets", "DateOfBirth", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pets", "DateOfBirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Pets", "Weight", c => c.Double(nullable: false));
        }
    }
}
