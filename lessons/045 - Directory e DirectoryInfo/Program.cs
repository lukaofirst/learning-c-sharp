using System;
using System.IO;
using System.Collections.Generic;

namespace programa45 {
    class Program {
        static void Main(string[] args) {
            // Directory e DirectoryInfo
            // Envolve todas a operações com pastas

            // Directory será muito semelhante ao File, simples, porém um pouco mais lenta devido a verificação de segurança
            // DirectoryInfo será muito semelhante ao FileInfo

            string path = @"C:\Users\lucas\Desktop\genericFolder";

            try {
                // Listando todas as pastas a partir de um caminho
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach(string s in folders) {
                    Console.WriteLine(s);
                }

                Console.WriteLine();
                
                // Listando todos os arquivos a partir de um caminho
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach(string s in files) {
                    Console.WriteLine(s);
                }

                // Criando uma pasta
                Directory.CreateDirectory(path + @"\newFolder");
            } catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
