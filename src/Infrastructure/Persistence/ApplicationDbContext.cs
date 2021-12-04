using System.Reflection;
using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SnackAttack.Application.Common.Interfaces;
using SnackAttack.Domain.Common;
using SnackAttack.Domain.Entities;

namespace SnackAttack.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        private readonly IDateTimeService _dateTimeService;

        public ApplicationDbContext(
              DbContextOptions<ApplicationDbContext> options,
              IDateTimeService dateTimeService) : base(options)
        {
            _dateTimeService = dateTimeService;
        }

        public DbSet<Snack> Snacks => Set<Snack>();
        public DbSet<Review> Reviews => Set<Review>();
        public DbSet<Company> Companies => Set<Company>();

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = "system";
                        entry.Entity.Created = _dateTimeService.NowInUtc;
                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = "system";
                        entry.Entity.LastModified = _dateTimeService.NowInUtc;
                        break;
                }
            }

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