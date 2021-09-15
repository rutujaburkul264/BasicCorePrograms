using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class FlippingCoin
    {
        public static void CoinFlip()
        {
            Random random = new Random();

            int Heads = 0;
            int Tails = 0;
            int Result = 0;

            for (int i = 0; i <= 10; i++)
            {
                Result = random.Next(0, 2);

                if (Result == 1)
                    Heads++;
                else
                    Tails++;
            }
            Console.WriteLine("HEADS was flipped {0} times", Heads);
            Console.WriteLine("TAILS was flipped {0} times", Tails);
        }
    }
}
