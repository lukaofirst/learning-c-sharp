using System;

namespace programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*** Operadores de Atribuição ***/

            // O sinal de + serve como concatenação cumulativa de strings
            String str1 = "ABC";
            String str2 = "DEF";

            Console.WriteLine(str1+str2);

            // Qual a diferença entre a++ e ++a;
            // Ambos tem a mesma finalidade, porém tem uma leve diferença, por exemplo:

            int a = 10;
            int b = a++;

            Console.WriteLine(a);       // Output 11
            Console.WriteLine(b);       // Output 10 -> Porque, nesse caso, primeiro vem a variável "a" e o incremento ele desconsidera;
            Console.WriteLine("-------------------");

            int c = 11;             
            int d = ++c;

            Console.WriteLine(c);       // Output 12
            Console.WriteLine(d);       // Output 12 -> Nesse caso, primeiro vem o incremento e é acrescido a variável "c";
            Console.WriteLine("-------------------");

            /*** Conversão Implítica e Casting ***/
            // É quando se quer converter uma variável em outra, a depender da quantidade de bytes, sempre do menor pro maior, é possível
            // Do maior pro menor, tem que fazer o [Casting], que o termo de responsabilidade

            // Por exemplo:
            int e = 10;
            int f = 4;

            // Caso queira que o resultado seja um double, faça um Casting, aqui, pode ser tanto o numerador quanto o denominador
            double resultado = (double) e / f;

            Console.WriteLine(resultado);



        }
    }
}
