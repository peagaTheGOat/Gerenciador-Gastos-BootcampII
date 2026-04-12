namespace GerenciadorGastos.ConsoleApp
{
    public class Gasto
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }

        public Gasto(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;
            Data = DateTime.Now;
        }
    }
}
