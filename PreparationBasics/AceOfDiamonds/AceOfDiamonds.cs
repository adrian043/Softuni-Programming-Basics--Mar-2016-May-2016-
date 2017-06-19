using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaidTowel
{
    class PlaidTowel
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char back = char.Parse(Console.ReadLine());
            char rhomb = char.Parse(Console.ReadLine());

            int dinamicBack2 = 1;
            int inner2 = n;
            if (n % 2 == 0)
            {
                inner2 = n + 1;
            }
            int side2 = n - 1;

            int bottomSide2 = 1;
            int bottomInner2 = n;
            int bottomBack2 = 1;

            Console.Write(new string(back, n));
            Console.Write(new string(rhomb, 1));
            Console.Write(new string(back, 2 * n - 1));
            Console.Write(new string(rhomb, 1));
            Console.WriteLine(new string(back, n));

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(back, side2));
                Console.Write(new string(rhomb, 1));
                Console.Write(new string(back, dinamicBack2));
                Console.Write(new string(rhomb, 1));
                Console.Write(new string(back, inner2));
                Console.Write(new string(rhomb, 1));
                Console.Write(new string(back, dinamicBack2));
                Console.Write(new string(rhomb, 1));
                Console.WriteLine(new string(back, side2));

                dinamicBack2 += 2;
                side2--;
                inner2 -= 2;
            }//top
            Console.Write(new string(rhomb, 1));
            Console.Write(new string(back, 2 * n - 1));
            Console.Write(new string(rhomb, 1));
            Console.Write(new string(back, 2 * n - 1));
            Console.WriteLine(new string(rhomb, 1)); //middle     

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(back, bottomSide2));
                Console.Write(new string(rhomb, 1));
                Console.Write(new string(back, bottomInner2));
                Console.Write(new string(rhomb, 1));
                Console.Write(new string(back, bottomBack2));
                Console.Write(new string(rhomb, 1));
                Console.Write(new string(back, bottomInner2));
                Console.Write(new string(rhomb, 1));
                Console.WriteLine(new string(back, bottomSide2));

                bottomSide2++;
                bottomInner2 -= 2;
                bottomBack2 += 2;
            }//bottom
            Console.Write(new string(back, n));
            Console.Write(new string(rhomb, 1));
            Console.Write(new string(back, 2 * n - 1));
            Console.Write(new string(rhomb, 1));
            Console.WriteLine(new string(back, n)); // finished1


        }
    }
}
