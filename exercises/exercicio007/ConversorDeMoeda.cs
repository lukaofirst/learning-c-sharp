namespace exercicio7 {
    class ConversorDeMoeda {
        public static double IoF = 6.0;
        public static double DolarParaReal(double precoDolar, double quantiaDolar) {
            double total = precoDolar * quantiaDolar;
            return total += total * IoF / 100.0;
        }
    }
}
