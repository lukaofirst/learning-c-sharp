namespace programa32.Entities {
    class Account {
        public int Number { get; private set; }
        public string Holder { get; private set; }

        // Perceba que aqui [Balance] foi declarado como "protected"
        // Isso significa que ele poderá ser alterado caso se tenha subclasses
        // E não poderá ser acessado em "Program.cs", por exemplo.
        public double Balance { get; protected set; }

        public Account() {

        }
        public Account(int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount) {
            Balance -= amount;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }
    }
}
