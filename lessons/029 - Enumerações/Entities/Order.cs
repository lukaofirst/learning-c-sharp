using System;
using programa29.Entities.Enums;

namespace programa29.Entities {
    class Order {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString() {
            return $"{Id}, {Moment}, {Status}";
        }
    }
}
