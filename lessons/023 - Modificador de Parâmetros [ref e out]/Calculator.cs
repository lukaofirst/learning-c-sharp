namespace programa23 {
    class Calculator {
        public static void Triple(ref int x) {
            x = x * 3;
        }

        public static void CalcTriple(int origin, out int result) {
            result = origin * 3;
        }
    }
}
