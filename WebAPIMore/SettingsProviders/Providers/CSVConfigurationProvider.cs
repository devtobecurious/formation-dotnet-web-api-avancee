using Microsoft.Extensions.Primitives;
using System.Data;

namespace SettingsProviders.Providers
{
    public class CSVConfigurationProvider : ConfigurationProvider
    {
        private Action<FileOptions> action;
        private string? content;
        private string[][]? contentDico;

        public CSVConfigurationProvider(Action<FileOptions> action)
        {
            this.action = action;
        }

        public override void Load()
        {
            var option = new FileOptions();
            this.action(option);

            this.content = File.ReadAllText(option.FilePath);
            var rows = this.content.Split(System.Environment.NewLine);

            this.contentDico = new string[rows.Length][];
            int i = 0;
            foreach (var row in rows)
            {
                var columns = row.Split(",");
                this.contentDico[i] = new string[columns.Length];
                int j = 0;
                foreach (var column in columns)
                {
                    this.contentDico[i][j] = column;
                    j++;
                }

                i++;
            }
        }

        public override bool TryGet(string key, out string? value)
        {
            var searchValue = this.contentDico?.Where(item => item[0] == key).Select(item => item[1]).FirstOrDefault();

            value = searchValue;

            return ! string.IsNullOrEmpty(searchValue);
        }
    }
}
