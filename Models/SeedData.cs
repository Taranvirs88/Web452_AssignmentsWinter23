using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Rulers.Data;
using System;
using System.Linq;

namespace Rulers.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RulersContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RulersContext>>()))
            {
                // Look for any Rulers.
                if (context.Ruler.Any())
                {
                    return;   // DB has been seeded
                }

                context.Ruler.AddRange(
                    new Ruler
                    {
                        RulerTypes = "Steel Ruler",
                        Colour = "Transparent",
                        RulerShape = "Rectangular",
                        Material="Wooden",
                        MeasurementSystem=24,
                        Price = 18,
                        Rating=3
                    },

                    new Ruler
                    {
                        RulerTypes = "Carpenters Ruler",
                        Colour = "light Brown",
                        RulerShape = "Rectangular",
                        Material = "Wooden",
                        MeasurementSystem = 19,
                        Price = 33,
                        Rating = 5
                    },

                    new Ruler
                    {
                        RulerTypes = "Yardstick Ruler",
                        Colour = "Transparent",
                        RulerShape = "Circular",
                        Material = "Aluminum",
                        MeasurementSystem = 15,
                        Price = 20,
                        Rating = 4
                    },

                    new Ruler
                    {
                        RulerTypes = "Seamstress Ruler",
                        Colour = "Light gray",
                        RulerShape = "Rectangular",
                        Material = "Plastic",
                        MeasurementSystem = 15,
                        Price = 20,
                        Rating = 4
                    },
                    new Ruler
                    {
                        RulerTypes = "Architect Scale",
                        Colour = "White",
                        RulerShape = "Circular",
                        Material = "Paper",
                        MeasurementSystem = 30,
                        Price = 30,
                        Rating = 4
                    },
                    new Ruler
                    {
                        RulerTypes = "Engineer Scale",
                        Colour = "White",
                        RulerShape = "Rectangular",
                        Material = "Wooden",
                        MeasurementSystem = 25,
                        Price = 50,
                        Rating = 5
                    },
                    new Ruler
                    {
                        RulerTypes = "Tape Measure",
                        Colour = "Transparent",
                        RulerShape = "Rectangular",
                        Material = "Steel",
                        MeasurementSystem = 15,
                        Price = 80,
                        Rating = 4
                    },
                    new Ruler
                    {
                        RulerTypes = "Traingle Scale Ruler",
                        Colour = "Transparent",
                        RulerShape = "Traingle",
                        Material = "Plastic",
                        MeasurementSystem = 30,
                        Price = 8,
                        Rating = 4
                    },
                    new Ruler
                    {
                        RulerTypes = "Fold Ruler",
                        Colour = "Transparent",
                        RulerShape = "Rectangular",
                        Material = "Alumium",
                        MeasurementSystem = 33,
                        Price = 8,
                        Rating = 4
                    },
                    new Ruler
                    {
                        RulerTypes = "T-Ruler",
                        Colour = "Gray",
                        RulerShape = "Circular",
                        Material = "Steel",
                        MeasurementSystem = 32,
                        Price = 18,
                        Rating = 5
                    }
                );
                context.SaveChanges();
            }
        }
    }
}