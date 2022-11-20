using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace cosafa.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<TeamModel> Teams { get; set; }
        public DbSet<PrizeModel> Prizes { get; set; }
        public DbSet<TournamentModel> Tournaments { get; set; }
        public DbSet<MatchupModel> Matchups { get; set; }
        public DbSet<MatchupEntryModel> MatchupEntries { get; set; }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}