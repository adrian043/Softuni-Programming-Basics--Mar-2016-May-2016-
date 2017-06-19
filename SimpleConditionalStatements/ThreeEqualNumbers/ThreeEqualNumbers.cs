using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeEqualNumbers
{
    class ThreeEqualNumbers
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var z = double.Parse(Console.ReadLine());

           if (x == y && y == z)
           {
               Console.WriteLine("yes");
           }
            else
           {
               Console.WriteLine("no");
           }
        }
    }
}
