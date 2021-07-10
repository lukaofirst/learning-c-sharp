using System;
using System.IO;

namespace programa41 {
    class Program {
        /* File, FileInfo e IOException */
        // File e FileInfo realize operações com arquivos seja criar, copiar, deletar, etc.
        // Além de ajudar na criação de objetos FileStream
        // IOException é forma de se lidar com exceções referente a files

        // File é do tipo [static members] isso significa que ele é mais "simples" mas é necessário se fazer a verificação de segurança
        // FileInfo é do tipo [instance members] isso significa que deve ser feita a instanciação, não sendo necessário a verificação de segurança

        // Obs.: Lembrando que essa classe [System.IO] pode mexer diretamente com o Sistema Operacional
        static void Main(string[] args) {
            string sourcePath = @"C:\Users\lucas\Desktop\test.txt";
            string targetPath = @"C:\Users\lucas\Desktop\test2.txt";

            try {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines) {
                    Console.WriteLine(line);
                }

            } catch (IOException e) {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}
