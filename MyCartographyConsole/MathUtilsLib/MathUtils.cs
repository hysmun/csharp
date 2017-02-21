using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilsLib
{
    public class MathUtils
    {
        static public double Distance(double x1, double y1, double x2, double y2)
        {
            double X, Y;
            X = x2 - x1;
            Y = y2 - y1;
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }
    }
}
