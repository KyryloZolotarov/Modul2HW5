using Newtonsoft.Json;

namespace Modul2HW5
{
    internal class ConfigReader
    {
        public Configurations GetConfigurations()
        {
            var config = File.ReadAllText("jsconfig.json");
            var configurations = JsonConvert.DeserializeObject<Configurations>(config);
            return configurations != null ? configurations : new Configurations();
        }
    }
}
