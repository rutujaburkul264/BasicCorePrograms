using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class QuotientAndRemainder
    {
            public static void QuotientRemainder()
            {

                int dividend;
                int divisor;
                Console.WriteLine("Enter Dividend : ");
                dividend = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Divisor : ");
                divisor = int.Parse(Console.ReadLine());

                int quotient = dividend / divisor;
                int remainder = dividend % divisor;

                Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
                Console.WriteLine("Quotient = " + quotient);
                Console.WriteLine("Remainder = " + remainder);
                Console.ReadLine();
            }
    }
}
