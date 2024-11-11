//6. Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.

using System;

namespace CSharp
{
    public class Question6
    {
        public static void PrintMultiplication()
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int multiplication = num1 * num2 * num3;
            Console.Write("The multiplication of three numbers are: " + multiplication);
        }
    }
}
