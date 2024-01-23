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
            // Configure relationships and constraints here

            modelBuilder.Entity<Event>()
                .HasOne(e => e.Quest)
                .WithOne(q => q.Event)
                .HasForeignKey<Quest>(q => q.EventId)
                .OnDelete(DeleteBehavior.Restrict); // or DeleteBehavior.Cascade if needed

            modelBuilder.Entity<Event>()
                .HasMany(e => e.Teams)
                .WithOne(t => t.Event)
                .HasForeignKey(t => t.EventId)
                .OnDelete(DeleteBehavior.Restrict); // or DeleteBehavior.Cascade if needed

            modelBuilder.Entity<Quest>()
                .HasMany(q => q.Challenges)
                .WithOne(c => c.Quest)
                .HasForeignKey(c => c.QuestId)
                .OnDelete(DeleteBehavior.Restrict); // or DeleteBehavior.Cascade if needed

            modelBuilder.Entity<Quest>()
                .HasMany(q => q.TeamQuests)
                .WithOne(tq => tq.Quest)
                .HasForeignKey(tq => tq.QuestId)
                .OnDelete(DeleteBehavior.Restrict); // or DeleteBehavior.Cascade if needed

            modelBuilder.Entity<Challenge>()
                .HasOne(c => c.Quest)
                .WithMany(q => q.Challenges)
                .HasForeignKey(c => c.QuestId)
                .OnDelete(DeleteBehavior.Restrict); // or DeleteBehavior.Cascade if needed

            modelBuilder.Entity<TeamQuest>()
                .HasKey(tq => new { tq.QuestId, tq.TeamId });

            modelBuilder.Entity<TeamQuest>()
                .HasOne(tq => tq.Quest)
                .WithMany(q => q.TeamQuests)
                .HasForeignKey(tq => tq.QuestId)
                .OnDelete(DeleteBehavior.Restrict); // or DeleteBehavior.Cascade if needed

            modelBuilder.Entity<TeamQuest>()
                .HasOne(tq => tq.Team)
                .WithMany(t => t.TeamQuests)
                .HasForeignKey(tq => tq.TeamId)
                .OnDelete(DeleteBehavior.Restrict); // or DeleteBehavior.Cascade if needed

            // Add other configurations as needed

            base.OnModelCreating(modelBuilder);
        }
    }
}

