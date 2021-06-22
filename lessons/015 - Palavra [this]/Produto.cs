using System.Globalization;

namespace programa15 {
    class Produto {
        /* Palavra [this] */
        // Ela faz a referência para o próprio objeto
        // Formas de utilizá-la:
        // 1ª Forma: Diferenciar atributos da classe de variáveis locais
        // 2ª Forma: Referenciar outro construtor em um construtor
        // 3ª Forma: Passar o próprio objeto como argumento na chamada de um método ou construtor

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() {
            Quantidade = 0;
        }

        public Produto(string nome, double preco) : this() {
            // Aqui é opcional o uso da palavra 'this'
            Nome = nome;    
            Preco = preco;
        }

        // Até esse ponto, está sendo 'carregado' os atributos anteriores a este.
        public Produto(string nome, double preco, int quantidade) : this(nome,preco) {
            Quantidade = quantidade;
        }
    }
}
