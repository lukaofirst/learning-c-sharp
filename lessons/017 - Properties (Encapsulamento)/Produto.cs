using System.Globalization;

namespace programa17 {
    class Produto {
        /* Properties (Encapsulamento)*/
        // É um membro que oferece uma forma de ler, gravar ou calcular o valor de um campo particular/privado
        // Essas properties pode ser usadas como atributos públicos, mas eles são métodos especiais
        // Esses métodos especiais são chamados de "acessadores"

        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        // No caso dessa propriedade, como ela precisa de um argumento pra preencher o campo 
        // É usado, em vez da palavra "nome" [dentro do if], usa-se o parâmetro "value"
        // Pois é ele que armazena o conteúdo do campo Nome
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public double Preco {
            get { return _preco; }
        }

        public int Quantidade {
            get { return _quantidade; }
        }

        public int GetQuantidade() {
            return _quantidade;
        }

        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }

        public override string ToString() {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}