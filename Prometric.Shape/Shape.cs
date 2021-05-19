using Prometric.Shape.Helper;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Prometric.Shape
{
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Triangle))]
    [XmlInclude(typeof(Quadrilateral))]
    [Serializable]
    public abstract class Shape:IComparable
    {
        public abstract double Area { get; set; }
        
        public abstract double Perimeter { get; set; }

        public abstract string Name { get; set; }

        public static double GetArea(Shape shape) =>shape.Area;

        public static double GetPerimeter(Shape shape) => shape.Perimeter;

        public static int Count { get; private set; }

        public Shape()
        {
            Count = Count + 1;
        }

        public static string SerializeObject<T>(T shapes,ISerializeStrategy serializer)
        {
            return serializer.SerializeObject(shapes);
        }

        public int CompareTo(object obj)
        {
            Shape shape = (Shape)obj;
            return String.Compare(this.Name, shape.Name);
        }

        public static IComparer<Shape> SortAreaAscending()
        {
            return new SortAreaAscendingHelper();
        }

        public static IComparer<Shape> SortAreaDescending()
        {
            return new SortAreaDescendingHelper();
        }

        public static IComparer<Shape> SortPerimeterAscending()
        {

            return new SortPerimeterAscendingHelper();
        }           
        
        public static IComparer<Shape> SortPerimeterDescending()
        {

            return new SortPerimeterDescendingHelper();
        }
            
        
    }
}