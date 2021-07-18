using System;
using System.IO;
using System.Collections.Generic;
using programa51.Entities;

namespace programa51 {
    class Program {
        static void Main(string[] args) {
            /* Interface IComparable */
            string path = @"C:\Users\lucas\Desktop\text.txt";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    List<Employee> list = new List<Employee>();
                    while(!sr.EndOfStream) {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();

                    foreach(Employee emp in list) {
                        Console.WriteLine(emp);
                    }
                }
            } catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
