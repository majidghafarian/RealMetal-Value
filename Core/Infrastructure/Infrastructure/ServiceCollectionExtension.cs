namespace Infrastructure
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IMetalPriceCalculator, MetalPriceCalculator>();
            return services;


        }
    }
}
