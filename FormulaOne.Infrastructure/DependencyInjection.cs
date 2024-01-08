using FormulaOne.Application.Common.Interfaces;
using FormulaOne.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FormulaOne.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            string? connectionString = configuration.GetConnectionString("Default");

            services.AddDbContext<IApplicationDbContext, ApplicationDbContext>(
                options => options.UseSqlite(connectionString)
            );

            return services;
        }
    }
}
