using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class LargestThreeNumbers
    {
        public static void LargestAmongThree()
        {
            int num1, num2, num3;

            num1 = 35;
            num2 = 20;
            num3 = 50;

            if (num1 > num2 && num1 > num3)
                Console.Write("Number one is the largest!\n");
            else if (num2 > num1 && num2 > num3)
                Console.Write("Number two is the largest!\n");
            else
                Console.Write("Number three is the largest!\n");
            
        }
    }
}
