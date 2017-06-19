using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInput01
{
    class circle
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string InitialRows = new String('*', size);
            string WhiteSpaces = new String(' ', size - 2);
            Console.WriteLine(InitialRows);

            for (int i = 0; i < size - 2; i = i + 1)
            {
                Console.Write('*');
                Console.Write(WhiteSpaces);
                Console.Write('*');
                Console.WriteLine();
            }

            Console.WriteLine(InitialRows);

        }
    }
}