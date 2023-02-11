namespace _003_static_members
{
    public static class Calculator
    {
        public static string Sum(double a, double b) => (a + b).ToString("F2");
        public static string Subtract(double a, double b) => (a - b).ToString("F2");
        public static string Multiple(double a, double b) => (a * b).ToString("F2");
        public static string Divide(double a, double b)
        {
            if (b.Equals(0))
                throw new DivideByZeroException();

            return (a / b).ToString("F2");
        }
    }
}
