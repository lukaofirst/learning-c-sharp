using System;
using System.IO;

namespace programa46 {
    class Program {
        static void Main(string[] args) {
            /* Path */
            // Realiza operações com strings que contém informações de arquivos ou pastas

            string path = @"C:\Users\lucas\Desktop\genericFolder\text1.txt";

            // No Windows, o separator char é o \, no Linux é /
            Console.WriteLine("DirectorySepartorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath " + Path.GetTempPath());
        }
    }
}
