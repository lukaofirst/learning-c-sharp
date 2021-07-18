using System;
using System.Collections.Generic;

namespace programa55 {
    class Program {
        static void Main(string[] args) {
            /* Conjuntos: HashSet<T> e SortedSet<T> */
            // Representa um conjunto de elementos (similar ao da Álgebra)
            //      - Não admite repetições
            //      - Elementos não possuem posição
            //      - Acesso, inserção e remoção de elementos são rápidos
            //      - Oferece operações eficientes de conjunto: interseção, união, diferença

            // Diferenças
            //      HashSet
            //          - Armazenamento em tabela hash
            //          - Extremamente rápido: inserção, remoção e busca O(1)
            //          - A ordem dos elementos não e garantida

            //      SortedSet
            //          - Armazenamento em árvore
            //          - Rápido: inserção, remoção e busca O(log(n))
            //          - Os elementos são armazenados ordenadamente conforme implementação IComparer<T>

            // Usando HashSet<T>
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Computer"));

            foreach (string p in set) {
                Console.WriteLine(p);
            }
        }
    }
}
