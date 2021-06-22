using System;
using System.Globalization;

namespace exercicio4 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre a largura e altura do retângulo:");

            Retangulo ret = new Retangulo();

            ret.Base = double.Parse(Console.ReadLine());
            ret.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"Área = {ret.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perímetro = {ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal = {ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
