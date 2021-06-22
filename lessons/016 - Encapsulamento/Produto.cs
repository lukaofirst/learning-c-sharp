using System.Globalization;

namespace programa16 {
    class Produto {
        /* Encapsulamento */
        // É uma forma que consiste em esconder detalhes de implementação de um componente, expondo-se apenas o necessário
        // Por exemplo, ao tornar um atributo de classe como private, será preciso usar os métodos [Get] e [Set] para poder manusear esse atributo
        // Com o [Get] e [Set] pode-se inserir como esses dados serão mostrados

        // Na declaração dos atributos, a convenção da sintaxe para um atributo privado é usar _nomeAtributo
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome() {
            return _nome;
        }

        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }

        public double GetPreco() {
            return _preco;
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