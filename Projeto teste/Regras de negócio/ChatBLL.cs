using System.Configuration;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Regras_de_negócio {
    public class ChatBLL {
        private static readonly string apiKey = ConfigurationManager.AppSettings["OpenAIChave"];
        private static readonly string endpoint = "https://api.openai.com/v1/chat/completions";

        public static async Task<string> ProcessarMensagemAsync(string mensagem) {
            using (var client = new HttpClient()) {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                var requestBody = new {
                    model = "gpt-3.5-turbo",
                    messages = new[] {
                        new { role = "user", content = mensagem }
                    }
                };

                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync(endpoint, content);
                var responseBody = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode) {
                    return $"Erro ao chamar API: {response.StatusCode} - {responseBody}";
                }

                dynamic jsonResponse = JsonConvert.DeserializeObject(responseBody);

                try {
                    return jsonResponse.choices[0].message.content.ToString();
                }
                catch {
                    return "Erro: a resposta da API não está no formato esperado.";
                }
            }
        }
    }
}
