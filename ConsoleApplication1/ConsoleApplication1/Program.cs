using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0, n;
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                string input = Console.ReadLine();
                n = Convert.ToInt32(input);

                if (n > 999)
                {
                    break;
                }
                else
                {
                    result = result + n;
                }
                System.Console.WriteLine(result);
            }
        }
    }
}