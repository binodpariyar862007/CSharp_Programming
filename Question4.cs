﻿/*4. Write a C# Sharp program to print the results of the specified operations.
Test data:
● -1 + 4 * 6
● ( 35+ 5 ) % 7
● 14 + -4 * 6 / 11
● 2 + 15 / 6 * 1 - 7 % 2 */

using System;

namespace CSharp
{
    public class Question4
    {
        public static void PrintSpecifiedNumber()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }
    }
}
