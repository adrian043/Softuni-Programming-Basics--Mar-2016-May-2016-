using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class RhombusOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write("*");

                for (int j = 1; j <= i-1; j++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();

            } //top

            for (int i = n-1; i >= 1; i--)
            {
                Console.Write(new string(' ', n - i));
                Console.Write("*");

                for (int j = i-1; j >= 1; j--)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            } //bottom
        }
    }
}
