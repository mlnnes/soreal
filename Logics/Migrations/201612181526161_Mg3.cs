namespace Logics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mg3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NowTvShows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NowSeason = c.Int(nullable: false),
                        NowEpisode = c.Int(nullable: false),
                        TvShow_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TvShows", t => t.TvShow_Id)
                .Index(t => t.TvShow_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NowTvShows", "TvShow_Id", "dbo.TvShows");
            DropIndex("dbo.NowTvShows", new[] { "TvShow_Id" });
            DropTable("dbo.NowTvShows");
        }
    }
}
