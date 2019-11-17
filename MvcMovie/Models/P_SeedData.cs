using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class P_SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                    new Product
                    {
                        p_code = "P00032",
                        p_name = "썬더G",
                        p_measure = 270,
                        p_many=23,
                        p_location="P-1",
                        p_comprice=100000,
                        p_amount = "(개)",
                        p_brandname = "롤러블레이드",
                        p_customerprice = 150000
                    },

                    new Product
                    {
                        p_code = "P0001V",
                        p_name = "썬더K",
                        p_measure = 270,
                        p_many = 3,
                        p_location = "P-2",
                        p_comprice = 100000,
                        p_amount = "(개)",
                        p_brandname = "롤러블레이드",
                        p_customerprice = 150000
                    },

                    new Product
                    {
                        p_code = "P000RE",
                        p_name = "썬더G",
                        p_measure = 280,
                        p_many = 43,
                        p_location = "P-3",
                        p_comprice = 100000,
                        p_amount = "(개)",
                        p_brandname = "롤러블레이드",
                        p_customerprice = 150000
                    },

                    new Product
                    {
                        p_code = "P000J",
                        p_name = "썬더H",
                        p_measure = 230,
                        p_many = 30,
                        p_location = "P-4",
                        p_comprice = 100000,
                        p_amount = "(개)",
                        p_brandname = "롤러블레이드",
                        p_customerprice = 150000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}