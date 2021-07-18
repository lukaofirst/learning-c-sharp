using System;
using System.IO;
using System.Collections.Generic;

namespace exercicio20 {
    class Program {
        static void Main(string[] args) {
            /* Dictionary - Exercicio de Fixação */
            // Lembre-se: O acesso da dictionary é feito através da Key e não do seu Value!
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try {
                Dictionary<string, int> dict = new Dictionary<string, int>();

                using (StreamReader sr = File.OpenText(path)) {
                    while(!sr.EndOfStream) {
                        string[] votingRecord = sr.ReadLine().Split(',');
                        string candidateName = votingRecord[0];
                        int candidateVotes = int.Parse(votingRecord[1]);

                        if(dict.ContainsKey(candidateName)) {
                            dict[candidateName] += candidateVotes;
                        } else {
                            dict[candidateName] = candidateVotes;
                        }
                    }

                    foreach(var item in dict) {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                }
            } catch(IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
