using System;
using System.ComponentModel;

namespace Studio_AreaOfACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            do {
                Console.WriteLine("Enter a radius: ");
                string radiusInput = Console.ReadLine();
                radius = double.Parse(radiusInput);
            } while (radius < 0);
            
            Console.WriteLine("The area of a circle of radius " + radius + " is: " + CircleFormulas.CircleArea(radius));
            Console.WriteLine("The circumference of a circle of radius " + radius + " is: " + CircleFormulas.CircleCircumference(radius));
            Console.WriteLine("The diameter of a circle of radius " + radius + " is: " + CircleFormulas.CircleDiameter(radius));

            double milesPerGallon;
            do
            {
                Console.WriteLine("Enter your car's miles per gallon: ");
                string milesInput = Console.ReadLine();
                milesPerGallon = double.Parse(milesInput);
            } while (milesPerGallon < 0);

            Console.WriteLine("It would take " + RoadTrip.GasNeeded(radius, milesPerGallon) + " gallons of gas to go around a circle with a radius of " + radius + ".");
        }
    }
}