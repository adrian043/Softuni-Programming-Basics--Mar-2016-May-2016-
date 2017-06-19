using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfter5Days
{
    class DateAfter5Days
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double month = double.Parse(Console.ReadLine());
            double monthLength = 0;

            if (month == 04 || month == 06 || month == 09 || month == 11)
            {
                monthLength = 30;
                days += 5;
                if (days > monthLength)
                {
                    days -= monthLength;
                    month++;
                }
                Console.WriteLine("{0}.{1:00}", days, month);
            }
            else if (month == 02)
            {
                monthLength = 28;
                days += 5;
                if (days > monthLength)
                {
                    days -= monthLength;
                    month++;
                }
                Console.WriteLine("{0}.{1:00}", days, month);
            }
            else
            {
                monthLength = 31;
                days += 5;
                if (days > monthLength)
                {
                    days -= monthLength ;
                    month++;
                }
                if (month > 12)
                {
                    month = 1;
                }
                Console.WriteLine("{0}.{1:00}", days, month);
            }
        }
    }
}
