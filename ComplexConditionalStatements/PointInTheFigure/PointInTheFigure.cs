using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class PointInTheFigure
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var isItInRect1 = (x > 0) && (x < 3*h) &&
                              (y > 0) && (y < h);
            var isItInRect2 = (x > 2) && (x < 4) &&
                              (y > 2) && (y < 8);
            var isItOnBorder = (x == 0) || (x == 3*h) ||
                              (y == 0) || (y == 2) ||
                              (x == 2) || (x == 4) ||
                              (y == 2) || (y == 8);

            if (isItInRect1 || isItInRect2)
            {
                Console.WriteLine("inside");
            }
            else if (isItOnBorder)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }

        }
    }
}
