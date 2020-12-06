using Hangfire;
using Newtonsoft.Json;
namespace Web.Extensions
{
    public static class HangfireConfigurationExtensions
    {
        public static void UseMedidatR(this IGlobalConfiguration globalConfiguration)
        {
            var jsonSettings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            globalConfiguration.UseSerializerSettings(jsonSettings);
        }
    }
}
