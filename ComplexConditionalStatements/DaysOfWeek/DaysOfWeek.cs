﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeek
{
    class DaysOfWeek
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());

            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Monday"); break;
                case 2:
                    Console.WriteLine("Tuesday"); break;
                case 3:
                    Console.WriteLine("Wednesday"); break;
                case 4:
                    Console.WriteLine("Thursday"); break;
                case 5:
                    Console.WriteLine("Friday"); break;
                case 6:
                    Console.WriteLine("Saturday"); break;
                case 7:
                    Console.WriteLine("Sunday"); break;
                default:
                    Console.WriteLine("Error"); break;
                    
            }
        }
    }
}