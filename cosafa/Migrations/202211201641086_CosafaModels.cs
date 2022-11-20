namespace cosafa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CosafaModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MatchupEntryModels",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        score = c.Double(nullable: false),
                        ParentMatchup_id = c.Guid(),
                        TeamCompeting_id = c.Guid(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.MatchupModels", t => t.ParentMatchup_id)
                .ForeignKey("dbo.TeamModels", t => t.TeamCompeting_id)
                .Index(t => t.ParentMatchup_id)
                .Index(t => t.TeamCompeting_id);
            
            CreateTable(
                "dbo.MatchupModels",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        MatchupRound = c.Int(nullable: false),
                        Winner_id = c.Guid(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TeamModels", t => t.Winner_id)
                .Index(t => t.Winner_id);
            
            CreateTable(
                "dbo.TeamModels",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        TeamName = c.String(),
                        TournamentModel_id = c.Guid(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TournamentModels", t => t.TournamentModel_id)
                .Index(t => t.TournamentModel_id);
            
            CreateTable(
                "dbo.PrizeModels",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        PlaceNumber = c.Int(nullable: false),
                        PlaceName = c.String(),
                        PrizeAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrizePercentage = c.Double(nullable: false),
                        TournamentModel_id = c.Guid(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TournamentModels", t => t.TournamentModel_id)
                .Index(t => t.TournamentModel_id);
            
            CreateTable(
                "dbo.TournamentModels",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        TournamentName = c.String(),
                        EntryFee = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.AspNetUsers", "TeamModel_id", c => c.Guid());
            CreateIndex("dbo.AspNetUsers", "TeamModel_id");
            AddForeignKey("dbo.AspNetUsers", "TeamModel_id", "dbo.TeamModels", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PrizeModels", "TournamentModel_id", "dbo.TournamentModels");
            DropForeignKey("dbo.TeamModels", "TournamentModel_id", "dbo.TournamentModels");
            DropForeignKey("dbo.MatchupEntryModels", "TeamCompeting_id", "dbo.TeamModels");
            DropForeignKey("dbo.MatchupModels", "Winner_id", "dbo.TeamModels");
            DropForeignKey("dbo.AspNetUsers", "TeamModel_id", "dbo.TeamModels");
            DropForeignKey("dbo.MatchupEntryModels", "ParentMatchup_id", "dbo.MatchupModels");
            DropIndex("dbo.PrizeModels", new[] { "TournamentModel_id" });
            DropIndex("dbo.AspNetUsers", new[] { "TeamModel_id" });
            DropIndex("dbo.TeamModels", new[] { "TournamentModel_id" });
            DropIndex("dbo.MatchupModels", new[] { "Winner_id" });
            DropIndex("dbo.MatchupEntryModels", new[] { "TeamCompeting_id" });
            DropIndex("dbo.MatchupEntryModels", new[] { "ParentMatchup_id" });
            DropColumn("dbo.AspNetUsers", "TeamModel_id");
            DropTable("dbo.TournamentModels");
            DropTable("dbo.PrizeModels");
            DropTable("dbo.TeamModels");
            DropTable("dbo.MatchupModels");
            DropTable("dbo.MatchupEntryModels");
        }
    }
}
