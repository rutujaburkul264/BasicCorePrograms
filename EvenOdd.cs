using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class EvenOdd
    {
        public static void EvenOddCheck()
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
                Console.WriteLine("Even Number : " +i);
            else
                Console.WriteLine("Odd Number : " +i);
        }
    }
}
