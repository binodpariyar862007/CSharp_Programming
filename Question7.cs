/*7. Write a C# Sharp program to print on screen the output of adding,
subtracting, multiplying and dividing two numbers entered by the user.
Test Data:
Input the first number: 25
Input the second number: 4
Expected Output:
25 + 4 = 29
25 - 4 = 21
25 x 4 = 100
25 / 4 = 6
25 mod 4 = 1*/

using System;

namespace CSharp
{
    public class Question7
    {
        public static void PrintAll()
        {
            Console.Write("Input the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Expected Output:");

            int sum = num1 + num2;
            int subtraction = num1 - num2;
            int multiplication = num1 * num2;
            int division = num1 / num2;
                int modulus = num1 % num2;

            Console.WriteLine(sum);
            Console.WriteLine(subtraction);
            Console.WriteLine(multiplication);
            Console.WriteLine(division);
            Console.WriteLine(modulus);
        }
    }
}
