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
            // on compare les valeur des 2 boudingBox
            double diff = pPolyline1.BoudingBox - pPolyline2.BoudingBox;

            // si la difference est inférieur à la precision alors on est bon
            if (Math.Abs(diff) < CartoObj.Precision)
                return 0;
            if (diff > 0)
                return 1;
            if (diff < 0)
                return -1;
            //on ne doit pas arriver jusqu'ici !
            throw new Exception(" compare fail !");
        }
    }
}






























