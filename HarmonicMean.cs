using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class HarmonicMean
    {
        public static void HarmonicNum()
        {
            int number;
            double s = 0.0;
            Console.WriteLine("Please enter the nth number");
            number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("Please enter a valid number");
            }
            for (int i = 1; i <= number; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
        }
    }
}
