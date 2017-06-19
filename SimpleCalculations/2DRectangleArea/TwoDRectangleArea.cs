using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDRectangleArea
{
    class TwoDRectangleArea
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
           
            var area = Math.Abs(x2 - x1) * Math.Abs(y1 - y2);
            var perimeter = (Math.Abs(x2 - x1) + Math.Abs(y1 - y2)) * 2;
            
            Console.WriteLine(area);
            Console.WriteLine(perimeter);

        }
    }
}
