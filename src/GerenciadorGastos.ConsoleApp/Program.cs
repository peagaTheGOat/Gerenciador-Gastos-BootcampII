using GerenciadorGastos.ConsoleApp;

var gerenciador = new Gerenciador();
bool executando = true;

Console.WriteLine("=== Gerenciador de Gastos Pessoais (v1.0.0) ===");

while (executando)
{
    Console.WriteLine("\n1. Adicionar Gasto");
    Console.WriteLine("2. Listar Gastos");
    Console.WriteLine("3. Ver Total");
    Console.WriteLine("4. Sair");
    Console.Write("Escolha uma opção: ");

    switch (Console.ReadLine())
    {
        case "1":
            Console.Write("Descrição: ");
            string desc = Console.ReadLine() ?? "";
            Console.Write("Valor: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal valor))
            {
                try {
                    gerenciador.AdicionarGasto(desc, valor);
                    Console.WriteLine(" Gasto adicionado!");
                } catch (Exception e) {
                    Console.WriteLine($" Erro: {e.Message}");
                }
            }
            break;

        case "2":
            var lista = gerenciador.ObterTodos();
            Console.WriteLine("\n--- Seus Gastos ---");
            foreach (var g in lista)
                Console.WriteLine($"{g.Data:dd/MM} - {g.Descricao}: R$ {g.Valor:F2}");
            break;

        case "3":
            Console.WriteLine($"\n Total Acumulado: R$ {gerenciador.CalcularTotal():F2}");
            break;

        case "4":
            executando = false;
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}
