using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PrimeFactorization
    {
           public static void Factorization()
            {
                int num, i;
                Console.WriteLine("Please enter your integer: ");
                num = int.Parse(Console.ReadLine());
                for (i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine(i + " is a factor of " + num);
                    }
                }
            }
    }
}
