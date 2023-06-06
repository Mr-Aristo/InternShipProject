using InternShipProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternShipProject.Concrete
{
    public class CircleManager : ICircleService
    {
        
        public double AreaOfCircle(double radius)
        {
            double PI = 3.14;
            double area;

            area = PI * (radius * 2);

            return area;
        }

       


    }
}
