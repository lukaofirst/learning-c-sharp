using System;
using System.IO;
using System.Globalization;
using exercicio016.Entities;

namespace exercicio016 {
    class Program {
        static void Main(string[] args) {
            /* Arquivos - Exercício de Fixação */
            Console.WriteLine("Enter file full path: ");

            // Leitura do caminho do arquivo por meio de dados de entrada
            string sourceFilePath = Console.ReadLine();

            try {
                // String que armazena a leitura das linhas do arquivo fornecido
                string[] lines = File.ReadAllLines(sourceFilePath);

                // Método da classe Path que retorna o nome do diretório
                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);

                // Configurando o output do arquivo
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.ifc";

                // Criação de uma pasta que irá conter o output
                Directory.CreateDirectory(targetFolderPath);

                // Inserido os dados no arquivo de saída usando um StreamWriter
                using (StreamWriter sw = File.AppendText(targetFilePath)) {
                    foreach (string line in lines) {
                        string[] fields = line.Split(",");
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine($"{prod.Name}, {prod.TotalValue().ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
            } catch (IOException e) {
                // Tratamento de Exceções
                Console.WriteLine($"An error occurred {e.Message}");
            }
        }
    }
}
