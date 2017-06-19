using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesToCentimeters
{
    class InchesToCentimeters
    {
        static void Main(string[] args)
        {
            var inch = double.Parse(Console.ReadLine());
            var cm = inch * 2.54;
            Console.WriteLine(cm);
        }
    }
}
