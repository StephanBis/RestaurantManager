namespace RestaurantManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gebruikers", "Rol", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Gebruikers", "Rol");
        }
    }
}
