using System.Configuration;

namespace Configuration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            var appSettings = ConfigurationManager.AppSettings;
            foreach (var key in appSettings.AllKeys)
            {
                var value = appSettings[key];
                Console.WriteLine($"Key: {key}, Value: {value}");
            }
        }
    }
}
