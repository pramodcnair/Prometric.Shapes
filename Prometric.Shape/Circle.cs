using System;

namespace Prometric.Shape
{
    [Serializable]

    public class Circle : Shape
    {
        const double PI = 3.14;

        public double Radius { get; set; }

        public override string Name { get => "Circle"; set => throw new NotImplementedException(); }

        private Circle(){ }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area { get => Math.Round(PI * Radius * Radius, 2); set => throw new NotImplementedException(); }

        public override double Perimeter { get => Math.Round(2 * PI * Radius, 2); set => throw new NotImplementedException(); }

    }
}
