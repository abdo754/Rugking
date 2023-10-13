using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Rugking.Data;  
using System;
using System.Linq;

namespace Rugking.Models  
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RugkingContext(
                serviceProvider.GetRequiredService<DbContextOptions<RugkingContext>>()))
            {
               
                if (context.Product.Any())
                {
                    return;   
                }

                context.Product.AddRange(
                    new Product
                    {
                        Name = "Heriz rug",
                        Price = 45.99M,
                        Description = "middle eastern",
                        Category = "Category 1",
                        Brand = "Heriz",
                        CustomerRating = 4.5
                    },

                    new Product
                    {
                        Name = "Kilim",
                        Price = 15.99M,
                        Description = "Empire Rug",
                        Category = "Category 2",
                        Brand = "Kilim",
                        CustomerRating = 3.9
                    },

                    new Product
                     {
                         Name = "Wool",
                         Price = 99M,
                         Description = "made of fur",
                         Category = "Category 5",
                         Brand = "Wool",
                         CustomerRating = 5.0
                     },
                     
                    new Product
                     {
                         Name = "Bidjar",
                         Price = 1M,
                         Description = "Turish name",
                         Category = "Category 1",
                         Brand = "Bidjar",
                         CustomerRating = 1.0
                     },

                    new Product
                     {
                         Name = "Tabriz",
                         Price = 4M,
                         Description = "Persian",
                         Category = "Category 3",
                         Brand = "Tabriz",
                         CustomerRating = 2.5
                     },

                     new Product
                        {
                            Name = "prayer",
                            Price = 4M,
                            Description = "fabric",
                            Category = "Category 4",
                            Brand = "Tabriz",
                            CustomerRating = 4.6
                     },

                      new Product
                      {
                          Name = "Bijar",
                          Price = 2.5M,
                          Description = "Balouchi",
                          Category = "Category 6",
                          Brand = "Bijar",
                          CustomerRating = 4.5
                      },

                      new Product
                       {
                           Name = "Afghan",
                           Price = 5M,
                           Description = "made in Afghanistan",
                           Category = "Category 1",
                           Brand = "Afghan",
                           CustomerRating = 3.1
                       },

                         new Product
                        {
                         Name = "Bakshaish",
                         Price = 5M,
                          Description = "made in Bakshaish",
                          Category = "Category 5",
                          Brand = "Bakshaish",
                          CustomerRating = 1.0
                        }










                );
                context.SaveChanges();
            }
        }
    }
}
