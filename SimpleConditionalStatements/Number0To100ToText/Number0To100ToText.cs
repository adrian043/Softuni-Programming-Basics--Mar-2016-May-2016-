using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number0To100ToText
{
    class Number0To100ToText
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (string i = "zero"; i <= "one hundred"; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
