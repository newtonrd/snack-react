using SnackAttack.Domain.Entities;
using SnackAttack.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using SnackAttack.Domain.Enums;

namespace SnackAttack.Infrastructure.Persistence
{

    public static class ApplicationDbContextSeed
    {
        public static async Task SeedSampleDataAsync(ApplicationDbContext context)
        {
            if (!context.Companies.Any())
            {
                context.Companies.Add(new Company
                {
                    Name = "Nabisco"
                });

                await context.SaveChangesAsync();
            }

            // Seed, if necessary
            if (!context.Snacks.Any())
            {
                var nabiscoCompany = context.Companies.First();
                context.Snacks.Add(new Snack
                {
                    Name = "Oreo",
                    Reviews = 
                    {
                        new Review { Rating = Rating.Average },
                    },
                    CompanyId = nabiscoCompany.Id
                });

                await context.SaveChangesAsync();
            }
        }
    }
}