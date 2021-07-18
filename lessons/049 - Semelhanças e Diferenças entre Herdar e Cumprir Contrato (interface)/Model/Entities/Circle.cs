﻿using System;
using System.Globalization;

namespace programa49.Model.Entities {
    class Circle : AbstractShape {
        public double Radius { get; set; }

        public override double Area() {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString() {
            return $"Circle color = {Color}, " +
                $"radius = {Radius.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
