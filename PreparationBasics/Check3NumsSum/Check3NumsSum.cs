using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check3NumsSum
{
    class Check3NumsSum
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());         
           
            if (first + second == third)
            {
                if (first > second)
                {
                    int num = first;
                    first = second;
                    second = num;
                }
                Console.WriteLine("{0} + {1} = {2}", first, second, third);
            }
            else if (second + third == first)
            {
                if (second > third)
                {
                    int num = second;
                    second = third;
                    third = num;
                }
                Console.WriteLine("{0} + {1} = {2}", second, third, first);
            }
            else if (first + third == second)
            {
                if (first > third)
                {
                    int num = first;
                    first = third;
                    third = num;
                }
                Console.WriteLine("{0} + {1} = {2}", first, third, second);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
