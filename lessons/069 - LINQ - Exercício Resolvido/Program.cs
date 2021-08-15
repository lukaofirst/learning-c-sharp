﻿using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using programa69.Entities;

namespace programa69 {
    class Program {
        static void Main(string[] args) {
            /* LINQ - Exercício Resolvido */
            Console.Write("Enter full ile path: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        list.Add(new Product(name, price));
                    }
                }

                var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                Console.WriteLine($"Average price = ${avg.ToString("F2", CultureInfo.InvariantCulture)}");

                var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
                foreach (string name in names) {
                    Console.WriteLine(name);
                }

            } catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
