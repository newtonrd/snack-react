using Microsoft.EntityFrameworkCore;
using SnackAttack.Domain.Entities;

namespace SnackAttack.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Snack> Snacks { get; }
        DbSet<Company> Companies { get; }
        DbSet<Review> Reviews { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}