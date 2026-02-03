using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "R",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Transformers",
                    ReleaseDate = DateTime.Parse("2007-7-3"),
                    Genre = "Science Fiction",
                    Rating = "PG-13",
                    Price = 9.99M
                },

                new Movie
                {
                    Title = "Pirates of the Caribbean: The Curse of the Black Pearl",
                    ReleaseDate = DateTime.Parse("2003-7-9"),
                    Genre = "Adventure",
                    Rating = "PG-13",
                    Price = 8.99M
                },

                new Movie
                {
                    Title = "The Count of Monte Cristo",
                    ReleaseDate = DateTime.Parse("2002-1-25"),
                    Genre = "Drama",
                    Rating = "PG-13",
                    Price = 7.99M
                },

                new Movie
                {
                    Title = "Pacific Rim",
                    ReleaseDate = DateTime.Parse("2013-7-12"),
                    Genre = "Science Fiction",
                    Rating = "PG-13",
                    Price = 9.99M
                }
            );
            context.SaveChanges();
        }
    }
}