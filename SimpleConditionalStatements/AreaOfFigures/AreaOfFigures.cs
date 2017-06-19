using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            var a = double.Parse(Console.ReadLine());
            
            

            if (figure == "square")
            {                  
                Console.WriteLine(a * a);
            }
            else if (figure == "rectangle")
            {
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            else if (figure == "circle")
            {
                Console.WriteLine(Math.PI * a * a);
            }
            else if (figure == "triangle")
            {
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b/2);
            }
            else
            {
                Console.WriteLine("Unknown figure");
            }
        }
    }
}
