using System;

namespace programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*** Entrada de Dados em C# ***/

            // O comando que faz a leitura dos dados do teclado é: Console.ReadLine();
            // Ele faz a leitura até a quebra de linha, e esses dados serão retornados no formato de string
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine($"O seu nome completo é {nomeCompleto}");
            Console.WriteLine("-------------------------------------------");


            // E se eu quiser escrever tais dados em uma única linha? Por exemplo: abacate tomate morango
            // Será preciso usar o método Split, onde será recortado a informação de uma string e será armazenado em um array
            string[] vetor = Console.ReadLine().Split(" ");

            string a = vetor[0];
            string b = vetor[1];
            string c = vetor[2];

            Console.WriteLine($"O nome da primeira informação digitada foi: {a}");
            Console.WriteLine($"O nome da segunda informação digitada foi: {b}");
            Console.WriteLine($"O nome da terceira informação digitada foi: {c}");

            // Convertendo os dados de entrada 

            // Caso eu queira que o dado de entrada seja do tipo [int], pois o [Console.ReadLine()] lida apenas com strings.
            // Utilize, nesse caso, [int.Parse(Console.ReadLine())]
            // A mesma lógica, serve para um double, char e assim por diante.
        }
    }
}
