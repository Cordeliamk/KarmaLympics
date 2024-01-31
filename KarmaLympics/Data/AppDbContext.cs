using KarmaLympics.Models;
using Microsoft.EntityFrameworkCore;

namespace KarmaLympics.Data {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }

        // DbSet properties for your models
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamQuest> TeamQuests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<TeamQuest>()
            .HasOne(tq => tq.Quest)
            .WithMany(q => q.TeamQuests)
            .HasForeignKey(tq => tq.QuestId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TeamQuest>()
            .HasOne(tq => tq.Team)
            .WithMany(t => t.TeamQuests)
            .HasForeignKey(tq => tq.TeamId)
            .OnDelete(DeleteBehavior.NoAction);
        }

    }
}

