using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Prometric.Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>
            {
                new Circle(10),
                new Triangle(10, 10, 10),
                new Triangle(10, 15, 15),
                new Triangle(10, 8, 6),
                new Quadrilateral(10, 20),
                new Quadrilateral(10, 10)
            };

            var noOfShapes = shapes.Count;

            PrintShapes(shapes);

            Console.WriteLine($"Total number of Shapes are {noOfShapes}");

            Console.WriteLine("===============================================");

            Console.WriteLine($"Converting object to XML");

            Console.WriteLine("===============================================");

            string serialized = Shape.SerializeObject(shapes, new XMLSerializerStrategy());//new JsonSerializerStrategy

            Console.WriteLine(serialized);

        
            Console.WriteLine("===============================================");

            Console.WriteLine("Sorting Areas of Shapes by ascending order");

            shapes.Sort(Shape.SortAreaAscending());

            PrintShapes(shapes);

            Console.WriteLine("Sorting Perimeter of Shapes by descending order");

            shapes.Sort(Shape.SortPerimeterDescending());

            PrintShapes(shapes);

            Console.Read();

        }

        public static void PrintShapes(List<Shape> shapes)
        {
            Console.WriteLine("===============================================");
            Console.WriteLine(shapes.ToStringTable(new[] { "Name", "Area", "Perimeter" }, a => a.Name, a => a.Area, a => a.Perimeter));
            Console.WriteLine("===============================================");

        }        
    }
}
