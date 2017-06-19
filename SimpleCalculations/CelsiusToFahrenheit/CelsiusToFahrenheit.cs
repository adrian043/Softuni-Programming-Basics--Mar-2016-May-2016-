using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    class CelsiusToFahrenheit
    {
        static void Main(string[] args)
        {
            var C = double.Parse(Console.ReadLine());
            var F = (C * 9/5) + 32;
            Math.Round(0.00);
            Console.WriteLine(F);
        }
    }
}
