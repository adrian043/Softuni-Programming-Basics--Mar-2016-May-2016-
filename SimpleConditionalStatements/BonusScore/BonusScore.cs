using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            double points = 0;
           

            if (number <= 100)
            {
                points += 5;
            }            
            else if (number < 1000)
            {
                points = points + (number * 0.2);
            }
            else
            {
                points = points + (number * 0.1);
            }
            if (number % 2 == 0)
            {
                points++;
            }
            if (number % 10 == 5)
            {
                points += 2;
            }
            Console.WriteLine(points);
            Console.WriteLine(number + points);
        }
    }
}
