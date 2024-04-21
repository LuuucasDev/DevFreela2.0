using DevFreela.Core.Repositories;
using DevFreela.Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DevFreela.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ISkillRepository, SkillRepository>();

            //services.AddScoped<IAuthService, AuthService>();
            //services.AddScoped<IPaymentService, PaymentService>();
            //services.AddScoped<IMessageBusService, MessageBusService>();

            return services;
        }
    }
}
