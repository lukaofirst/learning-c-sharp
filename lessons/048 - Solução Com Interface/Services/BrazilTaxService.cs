namespace programa48.Services {
    class BrazilTaxService : ITaxService {
        // Aqui é feita uma realização de interface e não uma herança
        public double Tax(double amount) {
            // O nome do método [Tax] deve ser o mesmo declarado na interface [ITaxService]
            if (amount <= 100.0) {
                return amount * 0.2;
            } else {
                return amount * 0.15;
            }
        }
    }
}
