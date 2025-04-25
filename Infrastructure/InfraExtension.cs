using Infrastructure.Repos.abstracts;
using Infrastructure.Repos.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class InfraExtension
    {
        public static IServiceCollection addInfraExtension(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
            return services;
        }

    }
}
