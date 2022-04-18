using ApartmentManagement.PaymentAPI.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApartmentManagement.PaymentAPI.Extension
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMongoDbSettings(this IServiceCollection services,
            IConfiguration configuration)
        {
            return services.Configure<MongoDbModel>(options =>
            {
                options.ConnectionString = configuration
                    .GetSection(nameof(MongoDbModel) + ":" + MongoDbModel.ConnectionStringValue).Value;
                options.Database = configuration
                    .GetSection(nameof(MongoDbModel) + ":" + MongoDbModel.DatabaseValue).Value;
            });
        }
    }
}
