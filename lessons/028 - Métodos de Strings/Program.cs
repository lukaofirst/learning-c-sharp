using System;

namespace programa28 {
    class Program {
        static void Main(string[] args) {
            /* Métodos de Strings */
            // Obs.: A string é imutável, por mais que utilize esses métodos [strOriginal] não é alterado
            string strOriginal = "abcde FGHIJ ABC abc DEFG   ";

            // Formatar
            string s1 = strOriginal.ToUpper();  // Converte para letras em caixa alta
            string s2 = strOriginal.ToLower();  // Converte para letras em caixa baixa
            string s3 = strOriginal.Trim();     // Remove todas os espaços em branco da string no início e no fim
            
            // Buscar
            int n1 = strOriginal.IndexOf("AB");         // Apenas valores numéricos - Retorna a primeira correspodência do index da string dentro do parênteses 
            int n2 = strOriginal.LastIndexOf("DE");     // Apenas valores numéricos - Retorna a última correspodência do index da string dentro do parênteses 
            
            // Recortar
            string s4 = strOriginal.Substring(6);       // Ele faz o recorte a partir de um index da string
            string s5 = strOriginal.Substring(6, 5);    // Esse segundo parâmetro serve pra limitar o final dessa string recortada

            // Substituir
            string s6 = strOriginal.Replace("A", "x");  // Ele substitui parte de uma string por outra 
            string s7 = strOriginal.Replace("G", " One Piece ");    // Obs.: Não é necessário possui o mesmo tamanho no replace

            // Booleanos
            bool b1 = String.IsNullOrEmpty(strOriginal);        // Verifica se a string é nula ou vazia
            bool b2 = String.IsNullOrWhiteSpace(strOriginal);   // Verifica se a string é nula ou apenas tem espaços em branco

            // Exibição de Cada Método
            Console.WriteLine($"String Original: - {strOriginal} -");
            Console.WriteLine($"ToUpper: - {s1} -");
            Console.WriteLine($"ToLower: - {s2} -");
            Console.WriteLine($"Trim: - {s3} -");
            Console.WriteLine($"IndexOf: - {n1} -");
            Console.WriteLine($"LastIndexOf: - {n2} -");
            Console.WriteLine($"String Substring(6): - {s4} -");
            Console.WriteLine($"String Substring(6, 5): - {s5} -");
            Console.WriteLine($"Replace('a', 'x'): - {s6} -");
            Console.WriteLine($"String Substring('G', ' One Piece '): - {s7} -");
            Console.WriteLine($"IsNullOrEmpty: {b1}");
            Console.WriteLine($"IsNullOrWhiteSpace: {b2}");
        }
    }
}
