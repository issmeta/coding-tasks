using System;
using System.Collections.Generic;
using System.Text;

namespace task_6_geometry
{
    interface ICylinder
    {

        public void SetRadius(double radius);

        public void SetHeight(double height);

        public double Volume();
    }
}
