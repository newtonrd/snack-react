using NodaTime;

namespace SnackAttack.Domain.Common
{
    public class AuditableEntity
    {
        public Instant? Created { get; set; }

        public string? CreatedBy { get; set; }

        public Instant? LastModified { get; set; }
        public string? LastModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}