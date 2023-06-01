namespace SettingsProviders.Providers
{
    public class CSVConfigurationSource : IConfigurationSource
    {
        private readonly Action<FileOptions> action;
        public CSVConfigurationSource(Action<FileOptions> action)
        {
            this.action = action;
        }

        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new CSVConfigurationProvider(this.action);
        }
    }
}
