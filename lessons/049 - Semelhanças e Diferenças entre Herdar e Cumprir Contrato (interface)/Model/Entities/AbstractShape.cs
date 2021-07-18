using programa49.Model.Enums;

namespace programa49.Model.Entities {
    abstract class AbstractShape : IShape {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
