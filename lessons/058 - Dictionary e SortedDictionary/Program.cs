using System;
using System.Collections.Generic;

namespace programa58 {
    class Program {
        static void Main(string[] args) {
            /* Dictionary e SortedDictionary */
            // É uma coleção de pares chave/valor
            // Os elementos são indexados pelo objeto chave (não possuem posição)
            // Usos comuns: cookies, localStorage ou qualquer modelo chave-valor

            // Alguns métodos importantes
            // dictionary[key] - acessa o elemento pela chave informada

            // Add(key, value) - adiciona elemento(exceção em caso de repetição)
            // Clear() - esvazia a coleção
            // Count - quantidade de elementos
            // ContainsKeys(key) - verifica se a dada chave existe
            // ContainsValue(value) - verifica se o dado valor existe
            // Remove(key) - remove um elemento pela chave

            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "999715747";
            cookies["phone"] = "987456478";

            Console.WriteLine(cookies["user"]);
            Console.WriteLine(cookies["phone"]);
            cookies.Remove("email");

            Console.WriteLine();
            if (cookies.ContainsKey("email")) {
                Console.WriteLine(cookies["email"]);
            } else {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine();
            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine();
            Console.WriteLine("ALL COOKIES: ");
            foreach (KeyValuePair<string, string> item in cookies) {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            // foreach(var item in cookies) {
            // Console.WriteLine($"{item.Key}: {item.Value}");
            // }
        }
    }
}
