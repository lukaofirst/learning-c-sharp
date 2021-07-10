using System;
using System.IO;

namespace programa44 {
    class Program {
        /* StreamWriter */
        // É uma stream (sequência de dados) capaz de escrever caracteres a partir de uma stream binária (Ex.: FileStream)
        // Oferece suporte a dados no formato de texto
        // Sua instanciação é feita por meio de construtores ou através do [File e FileInfo]
        static void Main(string[] args) {
            string sourcePath = @"C:\Users\lucas\Desktop\test.txt";
            string targetPath = @"C:\Users\lucas\Desktop\test2.txt";

            try {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath)) {
                    foreach (string line in lines) {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            } catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
