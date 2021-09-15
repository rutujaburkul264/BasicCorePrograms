using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PowerOfTwo
    {
        public static void powerOfTwo()
        {
            int n;
            Console.WriteLine("Enter the Number : ");
            n = int.Parse(Console.ReadLine());

            if (0 <= n && n < 31)
            {
                Console.WriteLine("The power's of 2 are:");
                for (int i = 0; i <= n; i++)
                {
                    Console.WriteLine(+(2 << i));
                }
            }
        }
    }
}
