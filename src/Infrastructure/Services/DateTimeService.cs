using NodaTime;
using SnackAttack.Application.Common.Interfaces;

namespace SnackAttack.Infrastructure.Services
{
    public class DateTimeService : IDateTimeService
    {
        public Instant NowInUtc => SystemClock.Instance.GetCurrentInstant();
    }
}