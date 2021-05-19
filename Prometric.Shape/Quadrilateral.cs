using System;

namespace Prometric.Shape
{
    [Serializable]
    public class Quadrilateral : Shape
    {
        public double Length { get; set; }

        public double Width { get; set; }

        public override string Name { get => (Length == Width) ? "Square" : "Rectangle"; set => throw new NotImplementedException(); }

        private Quadrilateral() { }

        public Quadrilateral(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double Area { get => Math.Round(Length * Width, 2); set => throw new NotImplementedException(); }

        public override double Perimeter{ get => Math.Round(2 * (Length + Width), 2); set => throw new NotImplementedException(); }

    }
}
