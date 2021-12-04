using Microsoft.EntityFrameworkCore;
using SnackAttack.Application.Common.Interfaces;
using SnackAttack.Domain.Entities;

namespace SnackAttack.Application.Services
{
    public class SnackService : ISnackService
    {
        private IApplicationDbContext _dbContext;

        public SnackService(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Snack>> GetAllSnacks()
        {
            return await _dbContext.Snacks.Include(t => t.Company).ToListAsync();
        }
    }
}