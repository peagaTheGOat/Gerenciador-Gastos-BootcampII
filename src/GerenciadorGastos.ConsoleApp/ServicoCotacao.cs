using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace GerenciadorGastos.ConsoleApp
{
    public class ServicoCotacao
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<decimal> ObterCotacaoDolarAsync()
        {
            try
            {
                // Faz a requisição na API Pública
                var response = await _httpClient.GetStringAsync("https://economia.awesomeapi.com.br/last/USD-BRL");
                
                // Lê o JSON retornado
                using var doc = JsonDocument.Parse(response);
                var root = doc.RootElement;
                
                // Pega o valor específico do Dólar
                var valorString = root.GetProperty("USDBRL").GetProperty("bid").GetString();
                
                // Converte para decimal
                return decimal.Parse(valorString ?? "0", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch
            {
                // Se der erro de internet, retorna 0 para não quebrar o app
                return 0m; 
            }
        }
    }
}
