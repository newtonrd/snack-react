using SnackAttack.Domain.Entities;
using SnackAttack.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using SnackAttack.Domain.Enums;

namespace SnackAttack.Infrastructure.Persistence
{

    public static class ApplicationDbContextSeed
    {
        public static async Task SeedDefaultUserAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var administratorRole = new IdentityRole("Administrator");

            if (roleManager.Roles.All(r => r.Name != administratorRole.Name))
            {
                await roleManager.CreateAsync(administratorRole);
            }

            var administrator = new ApplicationUser { UserName = "administrator@localhost", Email = "administrator@localhost" };

            if (userManager.Users.All(u => u.UserName != administrator.UserName))
            {
                await userManager.CreateAsync(administrator, "Administrator1!");
                await userManager.AddToRolesAsync(administrator, new[] { administratorRole.Name });
            }
        }

        public static async Task SeedSampleDataAsync(ApplicationDbContext context)
        {
            // Seed, if necessary
            if (!context.Snacks.Any())
            {
                context.Snacks.Add(new Snack
                {
                    Name = "Oreo",
                    Reviews = 
                    {
                        new Review { Rating = Rating.Average },
                    }
                });

                await context.SaveChangesAsync();
            }
        }
    }
}