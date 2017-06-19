using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            double totalPrice = 0;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    totalPrice = count * 0.50;
                    Console.WriteLine(totalPrice);
                }
                else if (product == "water")
                {
                    totalPrice = count * 0.80;
                    Console.WriteLine(totalPrice);
                }
                else if (product == "beer")
                {
                    totalPrice = count * 1.20;
                    Console.WriteLine(totalPrice);
                }
                else if (product == "sweets")
                {
                    totalPrice = count * 1.45;
                    Console.WriteLine(totalPrice);
                }
                else if (product == "peanuts")
                {
                    totalPrice = count * 1.60;
                    Console.WriteLine(totalPrice);
                }
            }
            //Sofia
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    totalPrice = count * 0.40;
                    Console.WriteLine(totalPrice);
                }
                else if (product == "water")
                {
                    totalPrice = count * 0.70;
                    Console.WriteLine(totalPrice);
                }
                else if (product == "beer")
                {
                    totalPrice = count * 1.15;
                    Console.WriteLine(totalPrice);
                }
                else if (product == "sweets")
                {
                    totalPrice = count * 1.30;
                    Console.WriteLine(totalPrice);
                }
                else if (product == "peanuts")
                {
                    totalPrice = count * 1.50;
                    Console.WriteLine(totalPrice);
                }
            }
            //Plovdiv
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    totalPrice = count * 0.45;
                    Console.WriteLine(totalPrice);
                }
                else if (product == "water")
                {
                    totalPrice = count * 0.70;
                    Console.WriteLine(totalPrice);
                }
                else if (product == "beer")
                {
                    totalPrice = count * 1.10;
                    Console.WriteLine(totalPrice);
                }
                else if (product == "sweets")
                {
                    totalPrice = count * 1.35;
                    Console.WriteLine(totalPrice);
                }
                else if (product == "peanuts")
                {
                    totalPrice = count * 1.55;
                    Console.WriteLine(totalPrice);
                }
            }
        }
    }
}
