using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenGradOf2
{
    class evenGradOf2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int i = 0; i <= n/2; i++)
            {               
                Console.WriteLine(num);
                num *= 4;
            }
        }
    }
}
