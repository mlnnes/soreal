namespace Logics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewOne5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Seasons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TvShowId = c.Int(nullable: false),
                        NumberOfSeason = c.Int(nullable: false),
                        NumberOfEpisodes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TvShows", t => t.TvShowId, cascadeDelete: true)
                .Index(t => t.TvShowId);
            
            CreateTable(
                "dbo.TvShows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                        Cast = c.String(),
                        TotalNumberOfSeasons = c.Int(nullable: false),
                        TotalNumberOfEpisodes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Seasons", "TvShowId", "dbo.TvShows");
            DropIndex("dbo.Seasons", new[] { "TvShowId" });
            DropTable("dbo.TvShows");
            DropTable("dbo.Seasons");
        }
    }
}
