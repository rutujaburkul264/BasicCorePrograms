using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class VowelConsonant
    {
        public static void VowelOrConsonant()
        {
            Console.WriteLine("Enter an alphabet: ");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("It is vowel");
                    break;
                case 'i':
                    Console.WriteLine("It is vowel");
                    break;
                case 'o':
                    Console.WriteLine("It is vowel");
                    break;
                case 'u':
                    Console.WriteLine("It is vowel");
                    break;
                case 'e':
                    Console.WriteLine("It is vowel");
                    break;
                default:
                    Console.WriteLine("It Is Consonant");
                    break;
            }
            Console.ReadKey();
        }
    }
}
