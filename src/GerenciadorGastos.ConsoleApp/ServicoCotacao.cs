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
                var response = await _httpClient.GetStringAsync("https://economia.awesomeapi.com.br/last/USD-BRL");
                
                using var doc = JsonDocument.Parse(response);
                var root = doc.RootElement;

                var valorString = root.GetProperty("USDBRL").GetProperty("bid").GetString();
                
                return decimal.Parse(valorString ?? "0", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch
            {
                return 0m; 
            }
        }
    }
}
