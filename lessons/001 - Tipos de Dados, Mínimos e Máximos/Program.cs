using System;

namespace Primeiro {
    class Program {
        static void Main(string[] args) {

            // Tipos de dado valor
            char letraD = '\u0044';     // Unicode que representa a letra D
            int number1 = 250;
            float number2 = 1000F;
            double number3 = 14534534534;
            bool booleano = true;

            // Tipos de dado referência
            String nome = "Lucas";
            Object obj1 = "Lucas Macedo";


            Console.WriteLine(letraD);
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(booleano);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);


            // Funções que verificam o valor mínimo e máximo dos tipos de dados
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
        }
    }
}
