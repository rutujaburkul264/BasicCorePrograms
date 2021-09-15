using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class SwapNumbers
    {
        public static void Swapping()
        {
                int num1, num2, temp;
                Console.Write("\nEnter the First Number : ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("\nEnter the Second Number : ");
                num2 = int.Parse(Console.ReadLine());

                temp = num1;
                num1 = num2;
                num2 = temp;

                Console.WriteLine("\nAfter Swapping : ");
                Console.WriteLine("\nFirst Number : " + num1);
                Console.WriteLine("\nSecond Number : " + num2);
                Console.ReadLine();
            
        }
    }
}
