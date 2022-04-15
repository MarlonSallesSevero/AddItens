using System;
using System.Globalization;
using ControleProdutos.Entities;
using System.Collections.Generic;

namespace ControleProdutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char opcao = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (opcao == 'c')
                {
                    list.Add(new Product(nome, price));
                }
                else if (opcao == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY):");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(nome, price, data));
                }
                else
                {
                    Console.Write("Customs fee:");
                    double cusFre = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(nome, price, cusFre));
                    
                }
            }
            Console.WriteLine("PRICE TAGS:");
            foreach (Product p in list)
            {
                Console.WriteLine(p.text());
            }
        }
    }
}
