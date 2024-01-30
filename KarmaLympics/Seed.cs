using KarmaLympics.Data;
using KarmaLympics.Models;
using Microsoft.EntityFrameworkCore;

namespace KarmaLympics {
    public class Seed {
        private readonly AppDbContext _dataContext;
        private readonly ILogger<Seed> _logger;

        public Seed(AppDbContext context, ILogger<Seed> logger) {
            _dataContext = context;
            _logger = logger;
        }

        public void SeedDataContext() {
            try {
                _dataContext.Database.Migrate();
                _logger.LogInformation("Database migration succeeded.");

                if (_dataContext.Events.Any()) {
                    _dataContext.RemoveRange(_dataContext.Events);
                    _dataContext.SaveChanges();
                    _logger.LogInformation("Existing data removed.");
                    var eventList = new List<Event>
                    {
                        new Event
                        {
                            EventName = "KarmaLympics2024",
                            HostName = "Cordelia",
                            HostMail = "Cordelia@Karmalympics.com",
                            Rules = "The first rule of Karmalympics, is that you never talk about Karmalympics",
                            Teams = new List<Team>
                            {
                                new Team
                                {
                                    TeamName = "Blue Team",
                                    TeamUrl = "https://team1.example.com",
                                },
                                new Team
                                {
                                    TeamName = "Red Team",
                                    TeamUrl = "https://team2.example.com",
                                },
                            },
                            Quest = new Quest
                            {
                                Name = "Test Quest",
                                HostQuest = true,
                                Challenges = new List<Challenge>
                                {
                                    new Challenge
                                    {
                                        ChallengeName = "Tip The Cow",
                                        MaxPoints = 100,
                                        GivenPoints = 50,
                                        Solution = "Solution 1",
                                    },
                                    new Challenge
                                    {
                                        ChallengeName = "Challenge 2",
                                        MaxPoints = 150,
                                        GivenPoints = 75,
                                        Solution = "Solution 2",
                                    },
                                }
                            }
                        }
                    };

                    _dataContext.Events.AddRange(eventList);
                    _dataContext.SaveChanges();

                    _logger.LogInformation("Seeding completed successfully.");
                } else {
                    _logger.LogInformation("Database already seeded. Skipping seeding process.");
                }
            }
            catch (Exception ex) {
                _logger.LogError(ex, "An error occurred during seeding.");
                throw; // Rethrow the exception to stop the application startup
            }
        }
    }
}
