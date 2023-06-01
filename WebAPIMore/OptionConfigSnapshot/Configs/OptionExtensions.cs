using System.Runtime.CompilerServices;

namespace OptionConfig.Configs
{
    public static class OptionExtensions
    {
        public static IServiceCollection AddSpecificsOptions(this IServiceCollection service, IConfiguration config)
        {
            var section = config.GetSection("Wookiee");
            service.Configure<Wookiee>(section);

            return service;
        }
    }
}
