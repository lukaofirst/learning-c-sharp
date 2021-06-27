using System;

namespace exercicio11 {
    class Program {
        static void Main(string[] args) {
            // Exercício de Fixação - Matrizes
            Console.WriteLine("Digite na mesma linha a quantidade de linhas e colunas da matriz, separadamente: ");

            string[] matRowsColumns = Console.ReadLine().Split(" ");
            int i = int.Parse(matRowsColumns[0]);
            int j = int.Parse(matRowsColumns[1]);

            int[,] mat = new int[i, j];

            for (int m = 0; m < i; m++) {
                string[] values = Console.ReadLine().Split(" ");

                for (int n = 0; n < j; n++) {
                    mat[m, n] = int.Parse(values[n]);
                }
            }

            int searchNum = int.Parse(Console.ReadLine());

            for (int m = 0; m < i; m++) {
                for (int n = 0; n < j; n++) {
                    if (mat[m, n] == searchNum) {
                        Console.WriteLine();
                        if (n > 0) {
                            Console.WriteLine($"Left: {mat[m, n - 1]}");
                        }
                        if (m > 0) {
                            Console.WriteLine($"Up: {mat[m - 1, n]}");
                        }
                        if (n < j - 1) {
                            Console.WriteLine($"Right: {mat[m, n + 1]}");
                        }
                        if (m < i - 1) {
                            Console.WriteLine($"Down: {mat[m + 1, n]}");
                        }
                    }
                }
            }
        }
    }
}
