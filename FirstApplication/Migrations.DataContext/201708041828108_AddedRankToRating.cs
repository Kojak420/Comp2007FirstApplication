namespace FirstApplication.Migrations.DataContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRankToRating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ratings", "Rank", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ratings", "Rank");
        }
    }
}
