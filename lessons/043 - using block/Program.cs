using System;
using System.IO;

namespace programa43 {
    class Program {
        /* using block */
        // É uma sintaxe simplificada que garante que os objetos [IDisposable] serão fechados
        // [IDisposable] são objetos que não são gerenciados pelo CLR, precisando serem fechados manualmente
        // Por exemplo: Font, FileStream, StreamReader, StreamWriter...
        static void Main(string[] args) {
            string path = @"C:\Users\lucas\Desktop\test.txt";

            try {
                /*using (FileStream fs = new FileStream(path, FileMode.Open)) {
                    using (StreamReader sr = new StreamReader(fs)) {
                        while (!sr.EndOfStream) {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }*/


                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            } catch (IOException e) {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}
