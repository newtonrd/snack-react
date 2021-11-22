using SnackAttack.Domain.Common;
using SnackAttack.Domain.Enums;

namespace SnackAttack.Domain.Entities
{
    public class Review : AuditableEntity
    {
        public int Id { get; set; }
        public Rating Rating { get; set; }

        public IList<Snack> Snacks {get; private set; } = new List<Snack>();
    }
}