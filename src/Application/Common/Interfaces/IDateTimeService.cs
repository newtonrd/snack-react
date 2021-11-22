using NodaTime;

namespace SnackAttack.Application.Common.Interfaces
{
    public interface IDateTimeService
    {
         Instant NowInUtc { get; }
    }
}