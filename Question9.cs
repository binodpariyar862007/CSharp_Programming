//9. Write a C# Sharp program that takes the radius of a circle as input and calculates the perimeter and area of the circle.

using System;

namespace CSharp
{
    public class Question9
    {
        public static void CalculateCircle()
        {
            Console.Write("Enter the radius of circle for perimeter: ");
            double radius = Convert.ToDouble (Console.ReadLine());

            double perimeter = 2 * 3.14 * radius;
            Console.WriteLine("The perimeter of circle is: "+perimeter);

            Console.Write("Enter the radius of circle for area: ");
            double area = 3.14 * radius * radius;

            Console.WriteLine("The area of circle is: " + area);
        }
    }
}
