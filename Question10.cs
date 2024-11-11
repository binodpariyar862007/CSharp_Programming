/*10.Write a C# Sharp program that takes distance and time as input and
displays speed in kilometres per hour and miles per hour.
Test Data:
Input distance(metres): 50000
Input timeSec(hour): 1
Input timeSec(minutes): 35
Input timeSec(seconds): 56
Expected Output:
Your speed in metres/sec is 8.686588
Your speed in km/h is 31.27172
Your speed in miles/h is 19.4355 */

using System;

namespace CSharp
{
    public class Question10
    {
        public static void DisplayAll()
        {
            Console.Write("Input distance (metres): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input time (hours): ");
            double hours = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input time (minutes): ");
            double minutes = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input time (seconds): ");
            double seconds = Convert.ToDouble(Console.ReadLine());

            double totalTimeInSeconds = (hours * 3600) + (minutes * 60) + seconds;

            double speedInMetersPerSec = distance / totalTimeInSeconds;
            double speedInKmh = (distance / 1000) / (totalTimeInSeconds / 3600);
            double speedInMilesPerHour = speedInKmh * 0.621371;

            Console.WriteLine("Your speed in metres/sec is {speedInMetersPerSec}");
            Console.WriteLine("Your speed in km/h is {speedInKmh}");
            Console.WriteLine("Your speed in miles/h is {speedInMilesPerHour}");
        }
    }
}