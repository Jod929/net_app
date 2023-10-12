using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Quotes.Data;
using System;
using System.Linq;

namespace Quotes.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new QuotesContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<QuotesContext>>()))
        {
            // Look for any movies.
            if (context.Quote.Any())
            {
                return;   // DB has been seeded
            }
            context.Quote.AddRange(
                new Quote
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M
                },
                new Quote
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M
                },
                new Quote
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M
                },
                new Quote
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M
                }
            );
            context.SaveChanges();
        }
    }
}