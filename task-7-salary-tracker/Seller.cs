using System;
using System.Collections.Generic;
using System.Text;

namespace Positions
{
    class Seller : IPosition
    {
        
        //свойство класса
        //его не видно извне, работает только внутри класса
        private double _sal; //дистанция
        private double _bassel; //бак проедет столько км
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
