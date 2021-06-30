using System;
using System.Collections.Generic;
using System.Text;

namespace Positions
{
    class Manager : IPosition
    {

        //свойство класса
        //его не видно извне, работает только внутри класса
        private double _sal;
        private double _bassel;
        private double _profit;

        public void SetProfit(double profit)
        {
            _profit = profit;
        }
        public double GetSalary(double sal)
        {
            double result = 0;
            result = Math.Pow(sal, 2) * 0.25 * Math.Pow(10, -3) + _profit * 0.5 * Math.Pow(10, -2);
            return result;
        }

        public void SetBasicSalary(double bassel)
        {
            _bassel = bassel;
            _sal = GetSalary(_bassel);
        }
        public double ShowSalary()
        {
            return _sal;
        }

    }
}
