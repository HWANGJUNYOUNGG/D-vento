using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class W_SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Warehouse.Any())
                {
                    return;   // DB has been seeded
                }

                context.Warehouse.AddRange(
                    new Warehouse
                    {
                        w_code = "W00001",
                        w_name = "재고명1",
                        w_amount=20,
                        w_location = "A-1"


                    },

                    new Warehouse
                    {
                        w_code = "W00002",
                        w_name = "재고명2",
                        w_amount = 23,
                        w_location = "A-2"

                    },

                    new Warehouse
                    {
                        w_code = "W00003",
                        w_name = "재고명3",
                        w_amount = 26,
                        w_location = "A-3"
                    },

                    new Warehouse
                    {
                        w_code = "W00004",
                        w_name = "재고명4",
                        w_amount = 29,
                        w_location = "A-4"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}