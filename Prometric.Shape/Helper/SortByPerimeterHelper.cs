using System.Collections.Generic;

namespace Prometric.Shape.Helper
{
    public class SortPerimeterAscendingHelper : IComparer<Shape>
    {
        public int Compare(Shape x, Shape y)
        {
            if (x.Perimeter > y.Perimeter)
            {
                return 1;
            }

            if (x.Perimeter < y.Perimeter)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    public class SortPerimeterDescendingHelper : IComparer<Shape>
    {
        public int Compare(Shape x, Shape y)
        {
            if (x.Perimeter < y.Perimeter)
            {
                return 1;
            }

            if (x.Perimeter > y.Perimeter)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
