using System;
using programa29.Entities;
using programa29.Entities.Enums;

namespace programa29 {
    class Program {
        /* Enumerações [enum] */
        // É um tipo especial de classe que especifica de forma literal um conjunto de constantes que estão relacionadas entre si
        // Repare que nesse exercício-exemplo como as dependências estão sendo feitas e como elas estão organizadas
        // [enum] é um tipo valor
        static void Main(string[] args) {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            // Convertendo enum para string
            string txt = OrderStatus.PendingPayment.ToString();

            //Convertendo string para enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
