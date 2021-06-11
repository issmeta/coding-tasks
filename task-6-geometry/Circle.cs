using System;
using System.Collections.Generic;
using System.Text;

namespace task_6_geometry
{
    class Circle : ICircle
    {
        private double _radius;

        public double Area()
        {
            return _radius * _radius * Math.PI;
        }

        public void SetRadius(double radius)
        {
            _radius = radius;
        }
    }
}
