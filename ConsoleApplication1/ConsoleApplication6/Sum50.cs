using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Sum50
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
