using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitsOrVegies
{
    class FruitsOrVegies
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            bool IsFruit = product == "banana" || product == "apple" || product == "kiwi" || 
                           product == "cherry" || product == "lemon" || product == "grapes";

            bool IsVegies = product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot";

            if (IsFruit)
            {
                Console.WriteLine("fruit");
            }
            else if (IsVegies)
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
