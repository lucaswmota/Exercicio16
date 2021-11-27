using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o Nome do Primeiro Produto: ");
            string nomeProduto1 = Console.ReadLine();

            Console.Write("Informe a quantidade do primeiro produto: ");
            double qtdProduto1 = double.Parse(Console.ReadLine());

            Console.Write("Informe o valor do Primeiro Produto: R$ ");
            double vlrProduto1 = double.Parse(Console.ReadLine());

            double totalProduto1 = qtdProduto1 * vlrProduto1;

            Console.Write("Informe o nome do segundo produto: ");
            string nomeProduto2 = Console.ReadLine();

            Console.Write("Informe a quantidade do segundo produto: ");
            double qtdProduto2 = double.Parse(Console.ReadLine());

            Console.Write("Informe o Valor do Segundo Produto: R$ ");
            double vlrProduto2 = double.Parse(Console.ReadLine());

            double totalProduto2 = qtdProduto2 * vlrProduto2;

            Console.Write("Informe o nome do Terceiro Produto: ");
            string nomeProduto3 = Console.ReadLine();

            Console.Write("Informe a quantidade do Terceiro Produto: ");
            double qtdProduto3 = double.Parse(Console.ReadLine());

            Console.Write("Informe a o valor do terceiro produto: R$ ");
            double vlrProduto3 = double.Parse(Console.ReadLine());

            double totalProduto3 = vlrProduto3 * qtdProduto3;

            Console.WriteLine("Produto: " + nomeProduto1 + " Valor Total: " + totalProduto1.ToString("C"));

            Console.WriteLine("Produto: " + nomeProduto2 + " Valor Total: " + totalProduto2.ToString("C"));

            Console.WriteLine("Produto: " + nomeProduto3 + " Valor Total: " + totalProduto3.ToString("C"));
            
            double totalVenda = totalProduto1 + totalProduto2 + totalProduto3;

            Console.WriteLine("Total da Venda: " + totalVenda.ToString("C"));

            Console.Write("Pressione qualquer tecla para encerrar...");
            Console.ReadKey();




        }
    }
}
