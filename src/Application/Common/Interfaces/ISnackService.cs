using SnackAttack.Domain.Entities;

namespace SnackAttack.Application.Common.Interfaces
{
    public interface ISnackService
    {
         Task<List<Snack>> GetAllSnacks();
    }
}