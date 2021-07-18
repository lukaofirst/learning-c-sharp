using System;
using System.Collections;

namespace exercicio018 {
    public class Temperature : IComparable {
        // The temperature value
        protected double temperatureF;

        public int CompareTo(object obj) {
            if (obj == null) return 1;

            Temperature otherTemperature = obj as Temperature;
            if (otherTemperature != null)
                return this.temperatureF.CompareTo(otherTemperature.temperatureF);
            else
                throw new ArgumentException("Object is not a Temperature");
        }

        public double Fahrenheit {
            get {
                return this.temperatureF;
            }
            set {
                this.temperatureF = value;
            }
        }

        public double Celsius {
            get {
                return (this.temperatureF - 32) * (5.0 / 9);
            }
            set {
                this.temperatureF = (value * 9.0 / 5) + 32;
            }
        }
    }
    class Program {
        static void Main(string[] args) {
            ArrayList temperatures = new ArrayList();

            Random rnd = new Random();

            for(int ctr = 1; ctr <= 10; ctr++) {
                int degrees = rnd.Next(0, 100);
                Temperature temp = new Temperature();
                temp.Fahrenheit = degrees;
                temperatures.Add(temp);
            }

            temperatures.Sort();

            foreach(Temperature temp in temperatures) {
                Console.WriteLine(temp.Fahrenheit);
            }
        }
    }
}
