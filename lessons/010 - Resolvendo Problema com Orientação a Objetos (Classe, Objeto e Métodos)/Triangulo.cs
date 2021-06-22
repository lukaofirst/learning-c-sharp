using System; // Importação de dependências

namespace programa10 {  // Namespace da classe
    class Triangulo {   // Nome da classe
        public double A;    
        public double B;
        public double C;
        // O prefixo "public" indica que o atributo ou método pode ser usado em outros arquivos

        public double Area() {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        // O [double] após o [public] representa o tipo de dado que o método retorna
        // Se ele não retorna nada, use a palavra "void"
    }
}
