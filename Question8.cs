
//8. Write a C# Sharp program that takes three letters and displays them inreverse order.

using System;

namespace CSharp
{
    public class Question8
    {
        public static void LettersInverseOrder()
        {
            Console.Write("Enter the first letter: ");
            char letter = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter the second letter: ");
            char letter1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter the third letter: ");
            char letter2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0},{1}, {2}",letter2, letter1,letter);
        }
    }
}
