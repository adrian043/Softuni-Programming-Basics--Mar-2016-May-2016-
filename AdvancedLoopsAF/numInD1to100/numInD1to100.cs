using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numInD1to100
{
    class numInD1to100
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n < 1 || n > 100)
            {
                Console.WriteLine("Invalid Input!");
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
