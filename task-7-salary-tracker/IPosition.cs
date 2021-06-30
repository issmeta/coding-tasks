using System;
using System.Collections.Generic;
using System.Text;

namespace Positions
{
    interface IPosition
    {
        
        public double GetSalary(double shifts);
        public void SetBasicSalary(double salary);
        public void SetProfit(double profit);
        public double ShowSalary();
    }

   

    

 
}
