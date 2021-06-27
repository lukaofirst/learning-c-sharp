using System;
using System.Collections.Generic;

namespace programa25 {
    class Program {
        static void Main(string[] args) {
            /* Listas */

            List<string> list = new List<string>();

            // [.Add] - Por padrão, ele adiciona no final da lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            // [.Insert] - Ele insere o elemento em um determinado index
            list.Insert(2, "Marco");

            foreach(string name in list) {
                Console.WriteLine(name);
            }

            // [.Count] - Faz a contagem do tamanho da lista
            Console.WriteLine("List count: " + list.Count);

            // [.Find]
            // Ele recebe um predicado que seria uma função onde pega o valor e retorna
            // Verdadeiro ou false com base na lógica da função
            string s1 = list.Find(x => x[0] == 'A'); // Dentro do método Find, tem-se uma expressão Lambda
            Console.WriteLine("First A: " + s1);

            // [.FindLast]
            // É a mesma lógica que o [.Find], porém, para a última correspondência
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A: " + s2);

            // [.FindIndex]
            // Encontra a primeira posição de elemento da lista que satisfaz um predicado
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            // [.FindLastIndex]
            // É a mesma lógica que o [.FindIndex], porém agora para a último posição de elemento da lista
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            // [.FindAll]
            // Filtra a lista com base em um predicado, criando uma nova lista que satisfaz o predicado
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------------");

            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            // [Remove, RemoveAll, RemoveAt, RemoveRange]
            // Remover elementos da lista

            // [.Remove]
            list.Remove("Alex");
            Console.WriteLine("---------------------------");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            // [.RemoveAll]
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---------------------------");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            // [.RemoveRange]
            /*list.RemoveRange(2, 2);
            Console.WriteLine("---------------------------");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }*/


            // [.RemoveAt]
            /*list.RemoveAt(1);
            Console.WriteLine("---------------------------");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }*/


        }
    }
}
