using Microsoft.Extensions.DependencyInjection;
using SnackAttack.Application.Common.Interfaces;
using SnackAttack.Application.Services;

namespace SnackAttack.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<ISnackService, SnackService>();

            return services;
        }
    }
}