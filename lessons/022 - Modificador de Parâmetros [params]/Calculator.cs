namespace programa22 {
    class Calculator {
        /* Modificador de Parâmetros: params */

        // 1ª Solução: Essa solução não é a ideal
        // Pois é preciso ficar colocando cada variável "na mão"

        /*      
                public static int Sum(int n1, int n2) {
                    return n1 + n2;
                }

                public static int Sum(int n1, int n2, int n3) {
                    return n1 + n2 + n3;
                }

                public static int Sum(int n1, int n2, int n3, int n4) {
                    return n1 + n2 + n3 + n4;
                }

                public static int Sum(int[] numbers) {
                    int sum = 0;
                    for (int i = 0; i < numbers.Length; i++) {
                        sum += numbers[i];
                    }
                    return sum;
        }*/

        // 2ª Solução: Uma boa solução, porém terá que instanciar os arrays 
        // Todas as vezes com o comando new
        /*public static int Sum(int[] numbers) {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }*/

        // 3ª Solução: Solução mais otimizada que a 2ª
        // Não será preciso instanciar todas as vezes
        // Apenas declare as variáveis dentro do método
        public static int Sum(int[] numbers) {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
