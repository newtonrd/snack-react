using System.Reflection;
using Microsoft.EntityFrameworkCore;
using SnackAttack.Application.Common.Interfaces;
using SnackAttack.Domain.Entities;

namespace SnackAttack.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(
              DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Snack> Snacks => Set<Snack>();

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            //TODO: extend saving entities with audit information
            var result = await base.SaveChangesAsync(cancellationToken);

            return result;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}