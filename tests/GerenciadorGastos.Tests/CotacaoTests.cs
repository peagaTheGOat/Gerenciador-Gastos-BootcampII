using System.Threading.Tasks;
using GerenciadorGastos.ConsoleApp;
using Xunit;

namespace GerenciadorGastos.Tests
{
    public class CotacaoTests
    {
        [Fact]
        public async Task ObterCotacaoDolar_DeveComunicarComAPIRetornarValorValido()
        {
            var servico = new ServicoCotacao();

            var cotacao = await servico.ObterCotacaoDolarAsync();

            Assert.True(cotacao > 0); 
        }
    }
}
