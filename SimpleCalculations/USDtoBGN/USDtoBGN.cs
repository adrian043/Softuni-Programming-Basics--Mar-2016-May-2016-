using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDtoBGN
{
    class USDtoBGN
    {
        static void Main(string[] args)
        {
            var USD = double.Parse(Console.ReadLine());
            var BGN = USD * 1.79549;
            BGN = Math.Round(BGN, 2);
            Console.WriteLine("{0} BGN", BGN);
        }
    }
}
