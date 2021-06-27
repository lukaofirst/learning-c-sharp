using System.Globalization;

namespace programa18 {
    class Produto {
        /* Auto Properties (Encapsulamento)*/
        // É uma forma ainda mais simplificada de se declarar as properties
        // Ela é recomendada para as propriedades que não precisam de uma lógica própria, ou seja,
        // Para as operações [get] [set]

        // Nesse caso, a property nome deve permanecer dessa forma [_nome]
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; set; }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}