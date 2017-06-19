using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyramidOfNums
{
    class pyramidOfNums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            int row = 1;
            bool print = true;

            while (print)
            {
                for (int i = n; i <= row; i++)
                {
                    Console.Write(number);
                    number++;
                    if (number == n)
                    {
                        print = false;
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
