﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumDigitsOfN
{
    class sumDigitsOfN
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            do
            {
                sum = sum + n % 10;
                
                n = n / 10;

            } while (n > 0);
           
            
            Console.WriteLine(sum);

        }
    }
}