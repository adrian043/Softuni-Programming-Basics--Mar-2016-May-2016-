﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersEndingIn7
{
    class NumbersEndingIn7
    {
        static void Main(string[] args)
        {
            for (int i = 7; i <= 1000; i += 10)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
