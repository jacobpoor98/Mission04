using System;
using Microsoft.EntityFrameworkCore;

namespace Mission04.Models
{
    public class MoviesContext: DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {
        }

        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    MovieID = 1,
                    Category = "Horror/Suspense",
                    Title = "I Am Legend",
                    Year = 2007,
                    Director = "Francis Lawrence",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new ApplicationResponse
                {
                    MovieID = 2,
                    Category = "Action/Adventure",
                    Title = "Hacksaw Ridge",
                    Year = 2016,
                    Director = "Mel Gibson",
                    Rating = "R",
                    Edited = false,
                    LentTo = "",
                    Notes = "Such an inspiring movie!"
                },
                new ApplicationResponse
                {
                    MovieID = 3,
                    Category = "Comedy",
                    Title = "Jumanji: The Next Level",
                    Year = 2017,
                    Director = "Jake Kasdan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }
            );
        }
    }
}
