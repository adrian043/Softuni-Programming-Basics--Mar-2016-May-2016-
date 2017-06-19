using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCalorie
{
    class DailyCalorie
    {
        static void Main(string[] args)
        {
            double weightInPounds = double.Parse(Console.ReadLine());
            double heightInInches = double.Parse(Console.ReadLine());
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            double workoutsPerWeek = double.Parse(Console.ReadLine());
            
            double dci = 0;
            double weightInKg = weightInPounds / 2.2;
            double heightInCm = heightInInches * 2.54;
            
            double Fbmr = 665 + (9.563 * weightInKg) + (1.85 * heightInCm) - (4.676 * age);           
            double Mbmr = 66.5 + (13.75 * weightInKg) + (5.003 * heightInCm) - (6.755 * age);            

            if (workoutsPerWeek <= 0)
            {
                dci = 1.2;
            }
            else if (workoutsPerWeek == 1 || workoutsPerWeek == 2 || workoutsPerWeek == 3)
            {
                dci = 1.375;
            }
            else if (workoutsPerWeek == 4 || workoutsPerWeek == 5 || workoutsPerWeek == 6)
            {
                dci = 1.55;
            }
            else if (workoutsPerWeek == 7 || workoutsPerWeek == 8 || workoutsPerWeek == 9)
            {
                dci = 1.725;
            }
            else
            {
                dci = 1.9;
            }
            if (gender == 'm')
            {
                Console.WriteLine(Math.Floor((dci * Mbmr)));
            }
            else
            {
                Console.WriteLine(Math.Floor((dci * Fbmr)));
            }

        }
    }
}
