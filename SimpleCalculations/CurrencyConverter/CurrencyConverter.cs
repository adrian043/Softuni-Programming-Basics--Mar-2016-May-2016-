using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            var input = double.Parse(Console.ReadLine());
            var currency1 = Console.ReadLine();
            var currency2 = Console.ReadLine();
            

            if (currency1 == "BGN")
            {                
                if (currency2 == "USD")
                {
                    Console.WriteLine("{0:0.00} USD", input / 1.79549);
                }
                if (currency2 == "EUR")
                {
                    Console.WriteLine("{0:0.00} EUR", input / 1.95583);
                }
                if (currency2 == "GBP")
                {
                    Console.WriteLine("{0:0.00} GBP", input / 2.53405);
                }
            }
            else if (currency1 == "USD")
            {
                if (currency2 == "BGN")
                {
                    Console.WriteLine("{0:0.00} BGN", input * 1.79549);
                }
                if (currency2 == "EUR")
                {
                    Console.WriteLine("{0:0.00} USD", input / 1.0893);
                }
                if (currency2 == "GBP")
                {
                    Console.WriteLine("{0:0.00} GBP", input * 0.71);
                }
            }
            else if (currency1 == "EUR")
            {
                if (currency2 == "USD")
                {
                    Console.WriteLine("{0:0.00} EUR", input * 1.0893);
                }
                if (currency2 == "BGN")
                {
                    Console.WriteLine("{0:0.00} BGN", input * 1.95583);
                }
                if (currency2 == "GBP")
                {
                    Console.WriteLine("{0:0.00} GBP", input * 0.7717);
                }
            }
            else if (currency1 == "GBP")
            {
                if (currency2 == "USD")
                {
                    Console.WriteLine("{0:0.00} USD", input / 0.70858);
                }
                if (currency2 == "EUR")
                {
                    Console.WriteLine("{0:0.00} EUR", input / 0.7717);
                }
                if (currency2 == "BGN")
                {
                    Console.WriteLine("{0:0.00} BGN", input * 2.53405);
                }
            }
            else
            {
                Console.WriteLine("Wrong currency");
            }
            
        }
    }
}
