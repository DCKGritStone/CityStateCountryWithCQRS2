using CityStateCountryWithCQRS2.Domain;
using CityStateCountryWithCQRS2.Domain.Queries._City;
using CityStateCountryWithCQRS2.Domain.Queries._Country;
using CityStateCountryWithCQRS2.Domain.Queries._State;
using CityStateCountryWithCQRS2.Infrastructure.Data;
using CityStateCountryWithCQRS2.Infrastructure.Queries._City;
using CityStateCountryWithCQRS2.Infrastructure.Queries._Country;
using CityStateCountryWithCQRS2.Infrastructure.Queries._State;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CityStateCountryWithCQRS2.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CityStateCountryDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("CityStateCountryConnection") ??
                throw new InvalidOperationException("Connection string 'CityStateCountryConnection' not found ")));
            services.AddTransient<IRepository, BaseRepository>();
            services.AddTransient<IGetCityQuery, GetCityQuery>();
            services.AddTransient<IGetCountryOuery, GetCountryQuery>();
            services.AddTransient<IGetStateQuery, GetStateQuery>();

            return services;
        }
    }
}
