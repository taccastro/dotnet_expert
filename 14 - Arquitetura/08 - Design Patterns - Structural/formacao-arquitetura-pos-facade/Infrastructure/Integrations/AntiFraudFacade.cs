using Newtonsoft.Json;
using System.Text;

namespace AwesomeShopPatterns.API.Infrastructure.Integrations
{
    public class AntiFraudFacade : IAntiFraudFacade
    {
        public AntiFraudResultModel Check(AntiFraudModel model)
        {
            var json = JsonConvert.SerializeObject(model);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var url = "https://63178ecbece2736550b65df3.mockapi.io/api/v1/anti-fraud";

            using var client = new HttpClient();

            var antiFraudRequestResult = client.PostAsync(url, content).Result;
            var antiFraudResultString = antiFraudRequestResult.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<AntiFraudResultModel>(antiFraudResultString);
        }
    }
}