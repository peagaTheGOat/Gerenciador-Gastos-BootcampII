using GerenciadorGastos.ConsoleApp;
using Xunit;

namespace GerenciadorGastos.Tests
{
    public class GerenciadorTests
    {
        [Fact]
        public void AdicionarGasto_CaminhoFeliz_DeveAumentarLista()
        {
            // Arrange
            var gerenciador = new Gerenciador();

            // Act
            gerenciador.AdicionarGasto("Café", 5.50m);

            // Assert
            Assert.Single(gerenciador.ObterTodos());
            Assert.Equal(5.50m, gerenciador.CalcularTotal());
        }

        [Fact]
        public void AdicionarGasto_ValorNegativo_DeveLancarExcecao()
        {
            // Arrange
            var gerenciador = new Gerenciador();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => gerenciador.AdicionarGasto("Almoço", -10m));
        }

        [Fact]
        public void RemoverGasto_Inexistente_DeveRetornarFalso()
        {
            // Arrange
            var gerenciador = new Gerenciador();

            // Act
            bool resultado = gerenciador.RemoverGasto("Item que não existe");

            // Assert
            Assert.False(resultado);
        }
    }
}
