namespace Logics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mg : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TvShows", "NowSeason");
            DropColumn("dbo.TvShows", "NowEpisode");
            DropColumn("dbo.TvShows", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TvShows", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.TvShows", "NowEpisode", c => c.Int());
            AddColumn("dbo.TvShows", "NowSeason", c => c.Int());
        }
    }
}
