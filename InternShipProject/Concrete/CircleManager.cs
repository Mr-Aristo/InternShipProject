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
        private double _area;

        public CircleManager()
        { }

        public CircleManager(double area)
        {
            this._area = area;
        }

        public double AreaOfCircle(double radius)
        {
            double PI = 3.14;

            _area = PI * (radius * 2);

            return _area;
        }

        public double Area
        {
            get { return _area; }
        }



    }
}
