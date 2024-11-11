//5. Write a C# Sharp program to swap two numbers.

using System;

namespace CSharp
{
    public class Question5
    {
        public static void SwapNumbers()
        {
            int temp;
            int num1 = 1; 
            int num2 = 2;

            Console.WriteLine("Before swaping: " + num1);
            Console.WriteLine("Before swaping: " + num2);

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swaping: " + num1);
            Console.WriteLine("After swaping: " + num2);
        }
    }
}
