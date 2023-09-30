//using ConfigSample.Options;
using Microsoft.Extensions.Configuration;
using emojis_webapp;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MyConfigServiceCollectionExtensions
    {
        public static IServiceCollection AddConfig(
             this IServiceCollection services, IConfiguration config)
        {
            return services;
        }

        public static IServiceCollection AddMyDependencyGroup(
             this IServiceCollection services)
        {
            //services.AddScoped<IMyDependency, MyDependency>();
            services.AddScoped<IGithubEmojiService, GithubEmojiService>();

            return services;
        }
    }
}