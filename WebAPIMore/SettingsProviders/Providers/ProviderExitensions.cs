using Microsoft.Extensions.Configuration;

namespace SettingsProviders.Providers
{
    public static class ProviderExtensions
    {
        public static IConfigurationBuilder AddCSVConfiguration(
               this IConfigurationBuilder builder,
               Action<FileOptions> optionsAction)
        {
            return builder.Add(new CSVConfigurationSource(optionsAction));
        }
    }
}

