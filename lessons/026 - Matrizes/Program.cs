using System;

namespace programa26 {
    class Program {
        static void Main(string[] args) {
            /* Matrizes */

            // Instanciando uma matriz
            double[,] matr = new double[2, 3];

            // Propriedades [Length, Rank e GetLength]

            // [Length] - Mostra a quantidade de elementos da matriz
            Console.WriteLine(matr.Length);  // Output 6

            // [Rank] - Mostra a quantidade de linhas da matriz
            Console.WriteLine(matr.Rank);    // Output 2

            // [GetLength] - Mostra o valor da dimensão 
            Console.WriteLine(matr.GetLength(0)); // Output 2 
            Console.WriteLine(matr.GetLength(1)); // Output 3;

            Console.WriteLine("--------------");

            // Matrizes - Exercício Exemplo
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Main Diagonal: ");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negative numbers: " + count);
        }
    }
}
