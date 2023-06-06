using InternShipProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternShipProject.Concrete
{
    public class TriangelManager : ITriangelService
    {
        public double AreaOfTriangel(double A, double B, double C)
        {
            double area = 0;
            double S;

            area = (A + B + C ) / 2;
            S= Math.Sqrt(area*(area-A)*(area-B)*(area-C));

            return S; 

        }
    }
}
