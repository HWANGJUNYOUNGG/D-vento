using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;

namespace MvcMovie.Models
{
    public class S_SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Sell.Any())
                {
                    return;   // DB has been seeded
                }

                context.Sell.AddRange(
                    new Sell
                    {
                        s_name = "썬더 G",
                        SellDate = DateTime.Parse("1989-2-12"),
                        s_amount = 28,
                        Price = 120000,
                        Rating = "70%"
                    },

                    new Sell
                    {
                        s_name = "썬더 K",
                        SellDate = DateTime.Parse("1990-2-12"),
                        s_amount = 28,
                        Price = 120000,
                        Rating = "13%"
                    },

                    new Sell
                    {
                        s_name = "썬더 L",
                        SellDate = DateTime.Parse("1999-2-12"),
                        s_amount = 28,
                        Price = 120000,
                        Rating = "15%"
                    },

                    new Sell
                    {
                        s_name = "썬더 J",
                        SellDate = DateTime.Parse("2001-2-12"),
                        s_amount = 28,
                        Price = 120000,
                        Rating = "70%"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
