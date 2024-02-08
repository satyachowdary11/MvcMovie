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
                    Title = "RRR",
                    ReleaseDate = DateTime.Parse("2022-06-17"),
                    Genre = "Action",
                    Rating = "8.0",
                    Price = 12M
                },
                new Movie
                {
                    Title = "Simhadri",
                    ReleaseDate = DateTime.Parse("2010-07-23"),
                    Genre = "family",
                    Rating = "8.5",
                    Price = 18M
                },
                new Movie
                {
                    Title = "Bahubali",
                    ReleaseDate = DateTime.Parse("2016-04-14"),
                    Genre = "Action and Adventure",
                    Rating = "8.8",
                    Price = 15M
                },
                new Movie
                {
                    Title = "Wolf of wall street",
                    ReleaseDate = DateTime.Parse("2016-05-07"),
                    Genre = "Adventure",
                    Rating = "9",
                    Price = 20.8M
                }
                new Movie
                {
                    Title = "Happy",
                    ReleaseDate = DateTime.Parse("2012-06-17"),
                    Genre = "Family Entertainer",
                    Rating = "7.5",
                    Price = 8.99M
                }
            );
            context.SaveChanges();
        }
    }
}