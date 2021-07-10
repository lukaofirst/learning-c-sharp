using System;
using System.IO;

namespace programa42 {
    class Program {
        static void Main(string[] args) {
            // FileStream e StreamReader

            // FileStream - É uma classe que faz o encapsulamento de um objeto a um arquivo de entrada e saída
            // Ela oferece suporte a dados binários
            // Sua instanciação pode ser feita por meio de construtores ou usando [Fil e FileInfo]

            // StreamReader - É uma stream que faz a leitura de caracteres a partir de uma stream binária [FileStream]
            // Ela oferece suporte a dados no formato de texto
            // Sua instanciação se dá por meio de construtores ou usando o [File e FileInfo]

            // Obs.: Stream significa a transmissão de dados em sequência
            string path = @"C:\Users\lucas\Desktop\test.txt";

            // FileStream fs = null;
            StreamReader sr = null;

            // Aqui o uso do FileStream e StreamReader é feito de uma forma mais "verbosa", e que é muito comum
            /*try {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            } catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            } finally {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }*/

            // Mesmo resultado do código acima, porém de maneira menos verbosa
            try {
                sr = File.OpenText(path);
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            } catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            } finally {
                if (sr != null) sr.Close();
            }
        }
    }
}
