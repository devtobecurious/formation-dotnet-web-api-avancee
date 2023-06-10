namespace LoggerBasicWithProvidersWithCustomProvider.Providers
{
    public record ConsoleConfig(ConsoleColor color);

    public class CustomConsoleLogger : ILogger
    {
        private readonly string name;
        private readonly Func<ConsoleConfig> config;

        public CustomConsoleLogger(string name, Func<ConsoleConfig> config)
        {
            (this.name, this.config) = (name, config);
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                return;
            }

            var config = this.config();
            var lastColor = Console.ForegroundColor;
            if (config != null)
            {
                Console.ForegroundColor = config.color;
                Console.WriteLine($"{name} - {state}");
            }
            Console.ForegroundColor = lastColor;
        }
    }

    [ProviderAlias("CustomConsole")]
    public class CustomConsoleLoggerProvider : ILoggerProvider
    {
        private Func<ConsoleConfig> config;

        public CustomConsoleLoggerProvider(Func<ConsoleConfig> config)
        {
            this.config = config;
        }

        public ILogger CreateLogger(string categoryName) => new CustomConsoleLogger(categoryName, this.config);

        public void Dispose()
        {
        }
    }
}
