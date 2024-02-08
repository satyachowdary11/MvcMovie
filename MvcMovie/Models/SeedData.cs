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
                    Title = "Bahubali",
                    ReleaseDate = DateTime.Parse("2015-12-15"),
                    Genre = "Ancient",
                    Rating = "9.0",
                    Price = 12M
                },
                new Movie
                {
                    Title = "Naruto",
                    ReleaseDate = DateTime.Parse("2015-06-22"),
                    Genre = "Anime",
                    Rating = "9.5",
                    Price = 10M
                },
                new Movie
                {
                    Title = "One Piece",
                    ReleaseDate = DateTime.Parse("2003-03-12"),
                    Genre = "Anime",
                    Rating = "9.8",
                    Price = 17M
                },
                new Movie
                {
                    Title = "Annabelle",
                    ReleaseDate = DateTime.Parse("2013-03-04"),
                    Genre = "Horror",
                    Rating = "9",
                    Price = 8.79M
                }
                new Movie
                {
                    Title = "Mirchi",
                    ReleaseDate = DateTime.Parse("2015-06-17"),
                    Genre = "Family Entertainer",
                    Rating = "8.5",
                    Price = 8.99M
                }
            );
            context.SaveChanges();
        }
    }
}