﻿using System.Globalization;

namespace programa013.Entities {
    class ImportedProduct : Product {
        public double CustomsFee { get; set; }

        public ImportedProduct() {
        }

        public ImportedProduct(string name, double price, double customsFee) 
            : base(name, price) {
            CustomsFee = customsFee;
        }

        public double TotalPrice() {
            return Price + CustomsFee;
        }

        public override string PriceTag() {
            return $"{Name} " +
                $"${Price} " +
                $"(Customs fee: " +
                $"${TotalPrice().ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
