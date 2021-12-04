using SnackAttack.Domain.Common;

namespace SnackAttack.Domain.Entities
{
    public class Company : AuditableEntity
    {
        public int Id { get; set; }
        public string? Name { get; set;}

        public List<Snack> Snacks { get; set; } = new List<Snack>();
    }
}