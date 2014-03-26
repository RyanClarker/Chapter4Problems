using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication7
{
    class Perfect
    {
        static void Main(string[] args)
        {
          
            for (int i = 1; i <= 1000; i++)
            {
                int sum = 0;

                for (int p = 1; p < i; p++)
                {
                    if (i % p == 0)
                    {
                        sum = sum + p;
                    }
                }

                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
               
                

        }
    }
}
