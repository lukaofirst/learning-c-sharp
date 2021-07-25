using System;
using System.Linq;
using System.Collections.Generic;

namespace programa65 {
    class Program {
        static void Main(string[] args) {
            /* Introdução ao LINQ */
            // LINQ - Language Integrated Query
            // É um conjunto de tecnologias baseadas na integração de funcionalidades de consulta diretamente na linguagem C#
            //      - Operações chamadas diretamente a partir das coleções
            //      - Consultas são objetos de primeira classe
            //      - Suporte do compilador e IntelliSense da IDE

            // Step-by-step:
            // 1) Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // 2) Define the query expression
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            // 3) Execute the query
            foreach(int x in result) {
                Console.WriteLine(x);
            }
        }
    }
}
