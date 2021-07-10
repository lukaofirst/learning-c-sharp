using exercicio015.Entities.Exceptions;

namespace exercicio015.Entities {
    class Account {
        // Propriedades Autoimplementadas
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        // Construtores
        public Account() {
        }

        public Account(int number, string holder, double balance, double withdrawLimit) {

            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        // Métodos Referentes a Classe
        public void Deposit(double amount) {
            Balance += amount;
        }

        public void Withdraw(double amount) {
            // Tratamento das Exceções
            // Aqui serão inseridos todas as regras de negócio relacionadas as possíveis exceções
            if(amount > WithdrawLimit) {
                throw new DomainException("The amount exceeds withdraw limit");
            }

            if(amount > Balance) {
                throw new DomainException("Not enough balance");
            }

            Balance -= amount;
        }
    }
}
