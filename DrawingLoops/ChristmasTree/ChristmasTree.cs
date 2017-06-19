using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var spaces = new string(' ', n + 1);

            Console.WriteLine("{0}|", spaces);
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write("*");

                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write("*");
                }
                for (int k = 0; k < 1; k++)
                {
                    Console.Write(" | ");
                }

                Console.Write("*");

                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            } 
        }
    }
}
   
