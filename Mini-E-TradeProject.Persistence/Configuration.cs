using Microsoft.Extensions.Configuration;

namespace Mini_E_TradeProject.Persistence
{
    static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/Mini-E-TradeProject.API"));
                configurationManager.AddJsonFile("appsettings.json");

                return configurationManager.GetConnectionString("MsSQLServer");
            }
        }
    }
}