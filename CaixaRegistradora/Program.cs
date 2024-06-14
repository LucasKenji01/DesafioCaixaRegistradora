using System;
using System.Globalization;

namespace CaixaRegistradora
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a quantidade de produtos: ");
            int quantidadeTotal = int.Parse(Console.ReadLine());

            decimal valorTotal = 0;

            Produto[] produtos = new Produto[quantidadeTotal];

            for(int i = 1; i <= quantidadeTotal; i++)
            {
                Console.Write("Produto: ");
                string nome = Console.ReadLine();

                Console.Write("Preço: ");
                decimal preco = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                produtos[i - 1] = new Produto { Nome = nome, Preco = preco, Quantidade = quantidade };

                valorTotal += preco * quantidade;

                Console.WriteLine("------------------------------------------");
            }

            Console.Clear();
            Console.WriteLine("CHECKOUT");

            foreach ( Produto produto in produtos )
            {
                Console.WriteLine(produto);
            }

            Console.WriteLine($"Valor total: $ {valorTotal}");
        }
    }
}