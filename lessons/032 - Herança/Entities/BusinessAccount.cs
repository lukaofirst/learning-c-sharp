namespace programa32.Entities {
    class BusinessAccount : Account {
        public double LoanLimit { get; set; }

        public BusinessAccount() {

        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance) {
            // O construtor da sub-base é feito colocando ": base(argumentos da superclasse aqui)" 
            // Essa forma reduz a escrita já feita no construtor de Account
            LoanLimit = loanLimit;
        }

        public void Loan(double amount) {
            if (amount <= LoanLimit) {
                Balance += amount;
            }
        }
    }
}
