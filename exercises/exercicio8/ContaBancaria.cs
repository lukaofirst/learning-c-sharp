using System;
using System.Globalization;

namespace exercicio8 {
    class ContaBancaria {
        // Propriedades Autoimplementadas
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double SaldoConta { get; private set; }


        // Construtores
        public ContaBancaria(int numero, string titular) {
            NumeroConta = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial): this(numero, titular) {
            DepositoConta(depositoInicial);
            // Chamando o método de depósito aqui, facilita caso,
            // Num futuro haja uma modificação nesse método
        }

        // Outros Métodos da Classe
        public void DepositoConta(double valor) {
            SaldoConta += valor;
        }

        public void SaqueConta(double valor) { 
            int taxa = 5;
            SaldoConta -= valor + taxa;
        }

        public override string ToString() {
            return $"Conta {NumeroConta}, " +
                $"Titular: {Titular}, " +
                $"Saldo: R$ " +
                $"{SaldoConta.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
