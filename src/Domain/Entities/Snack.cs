using SnackAttack.Domain.Common;

namespace SnackAttack.Domain.Entities
{
    public class Snack : AuditableEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}