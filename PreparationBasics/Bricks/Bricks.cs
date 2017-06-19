using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Bricks
    {
        static void Main(string[] args)
        {
            decimal countOfBricks = decimal.Parse(Console.ReadLine());
            decimal countOfWorkers = decimal.Parse(Console.ReadLine());
            decimal capacity = decimal.Parse(Console.ReadLine());
            
            decimal cources = countOfBricks / (countOfWorkers * capacity);                       
           
            Console.WriteLine(Math.Ceiling(cources));
        }
    }
}
