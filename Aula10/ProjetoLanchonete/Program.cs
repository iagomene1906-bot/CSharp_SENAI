namespace ProjetoLanchonete.Models;

class Program
{
    static void Main(string[] args)
    {
        List<Produto> pedido = new List<Produto>();

        pedido.Add(new Lanche("X-Salada", 26.00m));
        pedido.Add(new Bebida("X-Tapa", 6.70m));
        pedido.Add(new Sobremesa("Plutonita", 1.00m));

        Console.Clear();

        Console.WriteLine($"===== RESUMO DO PEDIDO =====");

        decimal total = 0m;

        foreach(Produto produto in pedido)
        {
            produto.exibirResumo();
            total += produto.calcularPrecoFinal();
        }

        Console.WriteLine($"Total do pedido: R${total:f2}");
        
    }
}
