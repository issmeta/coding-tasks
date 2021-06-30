using System;
using System.Collections.Generic;
using System.Text;

namespace Positions
{
    interface IPosition
    {
        
        public double GetSalary(double shifts);
        public void SetBasicSalary(double salary);
        //Метод инициализации прибыли компании
        public void SetProfit(double profit);
        //Метод возарвщает З/П работника
        public double ShowSalary();
    }

   

    

 
}
