using Microsoft.Extensions.Configuration;

namespace Nox.Ui.Data
{
    public static class ConfigurationHelper
    {
        public static IConfiguration Configuration { get; set; }

        private const string configurationLocation = "/Design/Configuration.ui.nox.yaml"; //TODO add to secrets

        private const string entityConfigurationLocation = "/Design/Entities/Currency/Currency.entity.nox.yaml"; //TODO add to secrets PLUS multiple entity file read

        public static string? ReadConfiguration()
        {
            return File.ReadAllText($"{Directory.GetCurrentDirectory()}{configurationLocation}");
        }

        public static string? ReadEntityConfiguration()
        {
            return File.ReadAllText($"{Directory.GetCurrentDirectory()}{entityConfigurationLocation}");
        }

    }
}

