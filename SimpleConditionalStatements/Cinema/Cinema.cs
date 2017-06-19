using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string tickets = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int sum = rows * columns;

            if (tickets == "Premiere")
            {
                double ticketPrice = 12.00;
                Console.WriteLine("{0:f2} leva", sum * ticketPrice);
            }
            else if (tickets == "Normal")
            {
                double ticketPrice = 7.50;
                Console.WriteLine("{0:f2} leva", sum * ticketPrice);
            }
            else if (true)
            {
                double ticketPrice = 5.00;
                Console.WriteLine("{0:f2} leva", sum * ticketPrice);
            }
        }
    }
}
