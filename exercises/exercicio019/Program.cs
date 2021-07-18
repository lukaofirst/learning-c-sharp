using System;
using System.Collections.Generic;

namespace exercicio19 {
    class Program {
        /* Conjuntos - Exercício de Fixação */
        static void Main(string[] args) {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                int registerNumberCourseA = int.Parse(Console.ReadLine());
                courseA.Add(registerNumberCourseA);
            }

            Console.WriteLine();
            Console.Write("How many students for course B? ");
            int j = int.Parse(Console.ReadLine());
            for (int i = 0; i < j; i++) {
                int registerNumberCourseB = int.Parse(Console.ReadLine());
                courseB.Add(registerNumberCourseB);
            }

            Console.WriteLine();
            Console.Write("How many students for course C? ");
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < k; i++) {
                int registerNumberCourseC = int.Parse(Console.ReadLine());
                courseC.Add(registerNumberCourseC);
            }

            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);

            Console.WriteLine($"Total students: {all.Count}");
        }
    }
}
