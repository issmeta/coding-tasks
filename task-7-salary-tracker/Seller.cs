using System;
using System.Collections.Generic;
using System.Text;

namespace Positions
{
    class Seller : IPosition
    {
        
        private double _sal; 
        private double _bassel; 
        private double _profit;
        public void SetProfit(double profit)
        {
            _profit = profit;
        }
        public double GetSalary(double sal)
        {
            _sal = sal;
            return _sal;
        }

        public void SetBasicSalary(double bassel)
        {
            _bassel = bassel;
            _sal= GetSalary(_bassel);
        }

        public double ShowSalary()
        {
            return _sal;
        }
    }
}
