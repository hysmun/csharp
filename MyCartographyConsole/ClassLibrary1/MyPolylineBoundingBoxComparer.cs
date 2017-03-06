using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartographyObjects
{
    public class MyPolylineBoundingBoxComparer : IComparer<Polyline>
    {
        public int Compare(Polyline pPolyline1, Polyline pPolyline2)
        {
            double boudingBox1 = pPolyline1.BoudingBox;
            double boudingBox2 = pPolyline2.BoudingBox;
            double diff = boudingBox1 - boudingBox2;
            if (Math.Abs(diff) < CartoObj.Precision)
                return 0;
            if (diff > 0)
                return 1;
            if (diff < 0)
                return -1;
            throw new Exception(" compare fail !");
        }
    }
}
