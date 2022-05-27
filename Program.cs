﻿using System;
using System.Collections.Generic;
using PrecoProduto.Entities;

namespace PrecoProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (c == 'i' || c == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    product.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (c == 'u' || c == 'U')
                {
                    Console.Write("Manufacture date: (DD/MM/YYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    product.Add(new UsedProduct(name, price, date));
                }
                else 
                {
                    product.Add(new Product(name,price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in product)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
