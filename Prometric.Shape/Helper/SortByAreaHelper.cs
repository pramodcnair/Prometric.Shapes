using System.Collections.Generic;

namespace Prometric.Shape.Helper
{
    public class SortAreaAscendingHelper : IComparer<Shape>
    {
        public int Compare(Shape x, Shape y)
        {
            if (x.Area > y.Area)
            {
                return 1;
            }

            if (x.Area < y.Area)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    public class SortAreaDescendingHelper : IComparer<Shape>
    {
        public int Compare(Shape x, Shape y)
        {
            if (x.Area < y.Area)
            {
                return 1;
            }

            if (x.Area > y.Area)
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
