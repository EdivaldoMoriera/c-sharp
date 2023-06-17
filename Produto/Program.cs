using System;

namespace Produto // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre com o valor");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

             Console.Write("Preço: ");
            p.Preco = Convert.ToDouble(Console.ReadLine());
            
             Console.Write("Quantidade no estoque");
            p.Quantidade = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Dados do Produto " + p.ToString());

            Console.WriteLine();
            Console.Write("digite a quantidade de produtos a ser adicionado ao estoque");
           int qte = Convert.ToInt32(Console.ReadLine());
           p.AdicionarProdutos(qte);

           Console.WriteLine("Dados atualizados: "+ p);


        }
    }
}