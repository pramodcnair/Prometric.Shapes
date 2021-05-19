using System;

namespace Prometric.Shape
{
    [Serializable]
    public class Triangle : Shape
    {
        public double SideA { get; set; }

        public double SideB { get; set; }

        public double SideC { get; set; }

        private double HalfPerimeter => Perimeter / 2;

        private Triangle() { }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public override double Area { get => Math.Round(Math.Sqrt(HalfPerimeter * (HalfPerimeter - SideA) * (HalfPerimeter - SideB) * (HalfPerimeter - SideC)), 2); set => throw new NotImplementedException(); }

        public override double Perimeter { get => Math.Round(SideA + SideB + SideC, 2); set => throw new NotImplementedException(); }

        public override string Name
        {
            get
            {
                if (SideA == SideB && SideB == SideC)
                {
                    return "Equilateral Triangle";
                }
                else if (SideA == SideB || SideA == SideC || SideB == SideC)
                {
                    return "Isosceles Triangle";
                }
                else
                {
                    return "Scalene Triangle";
                }
            }
            set=> throw new NotImplementedException(); 
        }
    }
}
