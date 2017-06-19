using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            var time1 = int.Parse(Console.ReadLine());
            var time2 = int.Parse(Console.ReadLine());
            var time3 = int.Parse(Console.ReadLine());
            var sum = time1 + time2 + time3;
            int minutes = 0;

            if (sum > 59)
            {
                minutes++;
                sum -= 60;
            }
            if (sum > 59)
            {
                minutes++;
                sum -= 60;
            }
            Console.WriteLine("{0}:{1:00} ", minutes, sum);
           
        }
    }
}
