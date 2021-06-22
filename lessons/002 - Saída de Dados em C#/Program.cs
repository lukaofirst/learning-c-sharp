using System;
using System.Globalization;

namespace segundoPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            /*** Saída de dados em C# ***/

            // Imprimir na saída padrão (console)
            Console.WriteLine("Salve, salve do C#");            // Aqui será adicionado uma quebra de linha
            Console.Write("Hey guys, I'm coming from C#");      // Não será adicionado uma quebra de linha
            Console.WriteLine("Eita...");                       // E aqui tá a prova ;)
            Console.WriteLine("--------------------------");


            // Controlando a quantidade de casas decimais
            double saldo = 256.49865;

            Console.WriteLine(saldo.ToString("F2"));            // Esse "F2" vai controlar quantas casas decimais serão mostrados
            Console.WriteLine("--------------------------");

            // Mudando o formato do número decimal de vírgula para ponto 
            double saldo2 = 5564.349509;
            Console.WriteLine("--------------------------");

            Console.WriteLine(saldo2.ToString("F3", CultureInfo.InvariantCulture));     
            // Para usar CultureInfo, é preciso usar a namespace System.Globalization

            // Placeholders, Concatenação e Interpolação
            String nome = "Lucas";
            int idade = 23;
            double saldo3 = 48.93490;

            // Placeholders
            Console.WriteLine("{0} tem {1} anos, e possui atualmente R$ {2:F2} reais", nome, idade, saldo3);

            // Concatenação (+ antigo)
            Console.WriteLine(nome + " tem " + idade + " anos, e possui atualmente R$ " + saldo3.ToString("F2", CultureInfo.InvariantCulture) + " reais");

            // Interpolação (+ atual)
            Console.WriteLine($"{nome} tem {idade} anos e, possui atualmente R$ {saldo3.ToString("F2", CultureInfo.InvariantCulture)} reais");
        }
    }
}
