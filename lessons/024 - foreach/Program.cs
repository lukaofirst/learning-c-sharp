using System;

namespace programa24 {
    class Program {
        static void Main(string[] args) {
            /* foreach */
            string[] names = new string[] { "Leon", "Chris", "Wesker" };

            foreach (string name in names) {
                Console.WriteLine(name);
            }
        }
    }
}
