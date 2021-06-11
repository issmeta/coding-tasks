using System;
using System.Collections.Generic;
using System.Text;

namespace task_6_geometry
{
    class Sphere : ISphere
    {
        private double _radius;

        public void SetRadius(double radius)
        {
            _radius = radius;
        }

        public double Volume()
        {
            return 4 * Math.PI * Math.Pow(_radius, 3) / 3;
        }
    }
}
