using System.Globalization;

namespace exercicio5 {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return (SalarioBruto - Imposto);
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto += ((SalarioBruto * porcentagem) / 100) - Imposto;
        }

        public override string ToString() {
            return $"{Nome}, R$ {SalarioBruto.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
