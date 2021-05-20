using System;

namespace task_2_time_converter
{
    class Program
    {
        static int ConvertDaysToHours(int days)
        {
            return days * 24;
        }

        static double ConvertDaysToHours(double days)
        {
            return days * 24;
        }

        static int ConvertHoursToMinutes(int hours)
        {
            return hours * 60;
        }

        static double ConvertHoursToMinutes(double hours)
        {
            return hours * 60;
        }

        static int ConvertMinutesToSeconds(int minutes)
        {
            return minutes * 60;
        }

        static double ConvertMinutesToSeconds(double minutes)
        {
            return minutes * 60;
        }

        static double ConvertSecondsToMinutes(int seconds)
        {
            return ((double)seconds) / 60;
        }

        static double ConvertMinutesToHours(int minutes)
        {
            return ((double)minutes) / 60;
        }

        static double ConvertHoursToDays(int hours)
        {
            return ((double)hours) / 24;
        }

        static void Main(string[] args)
        {
            int dth = ConvertDaysToHours(4);                    //конвертировать дни в часы
            Console.WriteLine("4 days in hours is " + dth);          //результат: 96

            int htm = ConvertHoursToMinutes(3);                 //конвертировать часы в минуты
            Console.WriteLine("3 hours in minutes is " + htm);      //результат: 180

            int mts = ConvertMinutesToSeconds(2);               //конвертировать минуты в секунды
            Console.WriteLine("2 minutes in seconds is " + mts);    //результат: 120

            double stm = ConvertSecondsToMinutes(42);           //конвертировать секунды в минуты
            Console.WriteLine("42 minutes in seconds is " + stm);   //результат: 0.7

            double mth = ConvertMinutesToHours(108);            //конвертировать минуты в часы
            Console.WriteLine("108 minutes in hours is " + mth);    //результат: 1.8

            double htd = ConvertHoursToDays(90);                //конвертировать часы в дни
            Console.WriteLine("90 hours in days is " + htd);         //результат: 3.75

            double dts = ConvertMinutesToSeconds(
                            ConvertHoursToMinutes(
                                ConvertDaysToHours(0.451)));    //конвертировать дни в секунды
            Console.WriteLine("0.451 days in seconds is " + dts);   //результат: 38966.4

            Console.ReadKey();                                 //пауза
        }
    }
}
