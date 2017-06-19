using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Minutes
{
    class TimePlus15Minutes
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());           
            var sum = minutes + 15;
            
            if (sum > 59)
            {
                hours++;
                sum -= 60;

            }
            else if (hours > 23)
            {
                hours++;
                sum -= 60;
            }
            Console.WriteLine(hours + sum);
            
        }
    }
}
