using SnackAttack.Domain.Common;

namespace SnackAttack.Domain.Entities
{
    public class Snack : AuditableEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public string? SubCategory { get; set; }

        public Company? Company { get; set; }
        public int CompanyId { get; set; }
        
        public IList<Review> Reviews { get; private set; } = new List<Review>();
    }
}