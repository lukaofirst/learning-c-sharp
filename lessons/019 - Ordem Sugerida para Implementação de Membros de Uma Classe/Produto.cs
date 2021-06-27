using System.Globalization;

namespace programa19 {
    class Produto {
        /* Ordem Sugerida para Implementação dos Membros */

        // 1) Atributos Privados
        private string _nome;

        // 2) Propriedades autoimplementadas
        public double Preco { get; private set; }
        public int Quantidade { get; set; }

        // 3) Construtores
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // 4) Propriedades Customizadas
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        // 5) Outros Métodos da Classe
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