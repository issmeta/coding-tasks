using System;
using System.Collections.Generic;
using System.Text;

namespace Positions
{
    class Driver : IPosition
    {

        //свойство класса
        //его не видно извне, работает только внутри класса
        private double _sal;
        private double _bassel;
        private double _profit;

        //Инициализация прибыли компании
        public void SetProfit(double profit)
        {
            _profit = profit;
        }
        //Подсчёт зарплаты
        public double GetSalary(double sal)
        {
            _sal = sal;
            double result = 0;
            result = _sal * 0.85;
            return result;
        }
        //Инициализация з/п работника
        public void SetBasicSalary(double bassel)
        {
            _bassel = bassel;
            _sal = GetSalary(_bassel);

        }
        //Метод возвращает зарплату
        public double ShowSalary()
        {
            return _sal;
        }

    }
}
