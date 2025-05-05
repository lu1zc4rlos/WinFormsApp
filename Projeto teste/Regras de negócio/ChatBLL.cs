using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Regras_de_negócio {
    public class ChatBLL {
        // Busca a chave da variável de ambiente
        private static readonly string apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY", EnvironmentVariableTarget.User);
        private static readonly string endpoint = "https://api.openai.com/v1/chat/completions";

        public static async Task<string> ProcessarMensagemAsync(string mensagem) {
            if (string.IsNullOrWhiteSpace(apiKey)) {
                return "Erro: Variável de ambiente OPENAI_API_KEY não encontrada.";
            }

            using (var client = new HttpClient()) {
                // Adiciona o cabeçalho Authorization
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                var requestBody = new {
                    model = "gpt-3.5-turbo",
                    messages = new[] {
                        new { role = "user", content = mensagem }
                    }
                };

                var json = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try {
                    var response = await client.PostAsync(endpoint, content);
                    var responseBody = await response.Content.ReadAsStringAsync();

                    if (!response.IsSuccessStatusCode) {
                        return $"Erro ao chamar API: {response.StatusCode} - {responseBody}";
                    }

                    dynamic jsonResponse = JsonConvert.DeserializeObject(responseBody);
                    return jsonResponse.choices[0].message.content.ToString();
                }
                catch (Exception ex) {
                    return $"Erro de conexão com a API: {ex.Message}";
                }
            }
        }
    }
}