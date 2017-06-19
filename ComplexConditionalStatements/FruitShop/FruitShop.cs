using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double totalPice = 0;

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || 
                dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                if (product == "banana")
                {
                    totalPice = quantity * 2.50;
                    Console.WriteLine(totalPice);
                }
                else if (product == "apple")
                {
                    totalPice = quantity * 1.20;
                    Console.WriteLine(totalPice);
                }
                else if (product == "orange")
                {
                    totalPice = quantity * 0.85;
                    Console.WriteLine(totalPice);
                }
                else if (product == "grapefruit")
                {
                    totalPice = quantity * 1.45;
                    Console.WriteLine(totalPice);
                }
                else if (product == "kiwi")
                {
                    totalPice = quantity * 2.70;
                    Console.WriteLine(totalPice);
                }
                else if (product == "pineapple")
                {
                    totalPice = quantity * 5.50;
                    Console.WriteLine(totalPice);
                }
                else if (product == "grapes")
                {
                    totalPice = quantity * 3.85;
                    Console.WriteLine(totalPice);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            // monday-friday
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                if (product == "banana")
                {
                    totalPice = quantity * 2.70;
                    Console.WriteLine(totalPice);
                }
                else if (product == "apple")
                {
                    totalPice = quantity * 1.25;
                    Console.WriteLine(totalPice);
                }
                else if (product == "orange")
                {
                    totalPice = quantity * 0.90;
                    Console.WriteLine(totalPice);
                }
                else if (product == "grapefruit")
                {
                    totalPice = quantity * 1.60;
                    Console.WriteLine(totalPice);
                }
                else if (product == "kiwi")
                {
                    totalPice = quantity * 3.00;
                    Console.WriteLine(totalPice);
                }
                else if (product == "pineapple")
                {
                    totalPice = quantity * 5.60;
                    Console.WriteLine(totalPice);
                }
                else if (product == "grapes")
                {
                    totalPice = quantity * 4.20;
                    Console.WriteLine(totalPice);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
