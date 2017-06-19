using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            var inputValue = double.Parse(Console.ReadLine());
            var inputMetric = Console.ReadLine();
            var outputMetric = Console.ReadLine();

            if (inputMetric == "m")
            {
                if (outputMetric == "mm")
                {
                    Console.WriteLine(inputValue * 1000);
                }
                else if (outputMetric == "cm")
                {
                    Console.WriteLine(inputValue * 100);
                }
                else if (outputMetric == "mi")
                {
                    Console.WriteLine(inputValue * 0.000621371192);
                }
                else if (outputMetric == "in")
                {
                    Console.WriteLine(inputValue * 2.54);
                }
                else if (outputMetric == "km")
                {
                    Console.WriteLine(inputValue * 0.001);
                }
                else if (outputMetric == "ft")
                {
                    Console.WriteLine(inputValue * 3.2808399);
                }
                else if (outputMetric == "yd")
                {
                    Console.WriteLine(inputValue * 1.0936133);
                }
            }

            else if (inputMetric == "mm")
            {
                if (outputMetric == "m")
                {
                    Console.WriteLine(inputValue / 1000);
                }
                else if (outputMetric == "cm")
                {
                    Console.WriteLine(inputValue / 10);
                }
                else if (outputMetric == "mi")
                {
                    Console.WriteLine(inputValue * 0.000000621371192);
                }
                else if (outputMetric == "in")
                {
                    Console.WriteLine(inputValue / 25.4);
                }
                else if (outputMetric == "km")
                {
                    Console.WriteLine(inputValue * 0.000001);
                }
                else if (outputMetric == "ft")
                {
                    Console.WriteLine(inputValue * 0.0032808399);
                }
                else if (outputMetric == "yd")
                {
                    Console.WriteLine(inputValue * 0.0010936133);
                }
            }
            else if (inputMetric == "cm")
            {
                if (outputMetric == "mm")
                {
                    Console.WriteLine(inputValue * 10);
                }
                else if (outputMetric == "m")
                {
                    Console.WriteLine(inputValue / 100);
                }
                else if (outputMetric == "mi")
                {
                    Console.WriteLine(inputValue * 0.00000621371192);
                }
                else if (outputMetric == "in")
                {
                    Console.WriteLine(inputValue * 0.393701);
                }
                else if (outputMetric == "km")
                {
                    Console.WriteLine(inputValue * 0.00001);
                }
                else if (outputMetric == "ft")
                {
                    Console.WriteLine(inputValue * 0.032808399);
                }
                else if (outputMetric == "yd")
                {
                    Console.WriteLine(inputValue * 0.010936133);
                }
            }
            else if (inputMetric == "mi")
            {
                if (outputMetric == "mm")
                {
                    Console.WriteLine(inputValue / 0.000000621371192);
                }
                else if (outputMetric == "cm")
                {
                    Console.WriteLine(inputValue / 0.00000621371192);
                }
                else if (outputMetric == "m")
                {
                    Console.WriteLine(inputValue / 0.000621371192);
                }
                else if (outputMetric == "in")
                {
                    Console.WriteLine(inputValue * 63360);
                }
                else if (outputMetric == "km")
                {
                    Console.WriteLine(inputValue * 1.60934);
                }
                else if (outputMetric == "ft")
                {
                    Console.WriteLine(inputValue * 3.2808399);
                }
                else if (outputMetric == "yd")
                {
                    Console.WriteLine(inputValue * 1.0936133);
                }
            }
            //else if (inputMetric == "in")
            //{

            //}
            //else if (inputMetric == "km")
            //{

            //}
            //else if (inputMetric == "ft")
            //{

            //}
            //else if (inputMetric == "yd")
            //{

            //}
            //else
            //{
            //    Console.WriteLine("Wrong metric");
            //}
        }
    }
}
