using Newtonsoft.Json;
using System.Text;

namespace Patterns.API.Infrastructure.Integrations
{
    public class AntiFraudFacade : IAntiFraudFacade
    {
        public AntiFraudResultModel Check(AntiFraudModel model)
        {
            try
            {
                var json = JsonConvert.SerializeObject(model);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var url = "https://63178ecbece2736550b65df3.mockapi.io/api/v1/anti-fraud";

                using var client = new HttpClient();
                var response = client.PostAsync(url, content).Result;

                // 🚨 Verifica se a API respondeu 200 OK
                if (!response.IsSuccessStatusCode)
                {
                    return new AntiFraudResultModel
                    {
                        IsValid = false,
                        Comments = $"API antifraude retornou erro HTTP {(int)response.StatusCode}"
                    };
                }

                var resultString = response.Content.ReadAsStringAsync().Result;

                // 🚨 Tenta converter, se falhar, retorna erro seguro
                try
                {
                    var result = JsonConvert.DeserializeObject<AntiFraudResultModel>(resultString);
                    if (result == null)
                    {
                        return new AntiFraudResultModel
                        {
                            IsValid = false,
                            Comments = "Resposta da API antifraude vazia ou inválida."
                        };
                    }

                    return result;
                }
                catch (JsonReaderException)
                {
                    return new AntiFraudResultModel
                    {
                        IsValid = false,
                        Comments = $"Erro ao ler resposta da API antifraude: {resultString}"
                    };
                }
            }
            catch (Exception ex)
            {
                return new AntiFraudResultModel
                {
                    IsValid = false,
                    Comments = $"Falha ao chamar API antifraude: {ex.Message}"
                };
            }
        }
    }
}
