using System.Collections.Generic;
using System.Linq;

namespace GerenciadorGastos.ConsoleApp
{
    public class Gerenciador
    {
        private List<Gasto> _gastos = new List<Gasto>();

        public void AdicionarGasto(string descricao, decimal valor)
        {
            if (string.IsNullOrWhiteSpace(descricao))
                throw new ArgumentException("A descrição não pode estar vazia.");

            if (valor <= 0)
                throw new ArgumentException("O valor deve ser maior que zero.");

            _gastos.Add(new Gasto(descricao, valor));
        }

        public List<Gasto> ObterTodos() => _gastos;

        public decimal CalcularTotal() => _gastos.Sum(g => g.Valor);

        public bool RemoverGasto(string descricao)
        {
            var gasto = _gastos.FirstOrDefault(g => g.Descricao.Equals(descricao, StringComparison.OrdinalIgnoreCase));
            if (gasto != null)
            {
                _gastos.Remove(gasto);
                return true;
            }
            return false;
        }
    }
}
