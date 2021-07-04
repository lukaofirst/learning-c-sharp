using System;

namespace programa27 {
    class Program {
        static void Main(string[] args) {
            /* Inferência de Tipos, switch-case e Expressão Condicional Ternária*/

            // Inferência de Tipos [var]
            // É uma forma de declarar uma variável sem necessariamente se preocupar com o tipo dela
            // Ou seja, [var] pode ser atribuída como double, string...
            // Agora, pode acontecer por um deslize que uma variável deveria ser double quando na verdade ela foi atribuída como do tipo string
            var m = "Lucas";
            var n = 10;
            Console.WriteLine($"{m}   {n}");
            Console.WriteLine("-------------------");
            Console.WriteLine("-------------------");

            // switch-case
            // É uma sintaxe que pode substituir longos encadeamentos if-else, isso para apenas o teste de uma única variável
            Console.Write("Digite entre Animes, Filmes e Séries: ");
            var myVariable = Console.ReadLine();

            switch (myVariable) {
                case "Animes": {
                    Console.WriteLine("Caso [Animes]");
                    break;
                }
                case "Filmes": {
                    Console.WriteLine("Caso [Filmes]");
                    break;
                }
                case "Séries": {
                    Console.WriteLine("Caso [Séries]");
                    break;
                }
                default: {
                    Console.WriteLine("Default");
                    break;
                }
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("-------------------");

            // Expressão Condicional Ternária
            // Estrutura condicional que pode substituir o if-else para um valor a partir de uma condição
            string playerName = "Coldzera";

            /*if(playerName == "Coldzera") {
                Console.WriteLine("O maior jogador de CSGO da história");
            } else {
                Console.WriteLine("Apenas um jogador");
            }*/

            var ternary = (playerName == "Coldzera") ? "The GOAT of CSGO" : "Just a player";
            Console.WriteLine("Usando o Operador Ternário: "+ ternary);
        }
    }
}
