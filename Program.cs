using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    /// <summary>
    /// Solution to Programming Assignment 1
    /// </summary>
    class Program
    {
        /// <summary>
        /// Calculates the distance between two points and the
        /// angle between those two points
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Welcome to the Greek Calculator!");
            Console.WriteLine();
            Console.WriteLine("You'll enter the x and y values for two points and");
            Console.WriteLine("I'll tell you the distance and angle between those");
            Console.WriteLine("points");
            Console.WriteLine();

            // prompt for and get first point
            Console.Write("Enter X for first point: ");
            float point1X = float.Parse(Console.ReadLine());
            Console.Write("Enter Y for first point: ");
            float point1Y = float.Parse(Console.ReadLine());

            // prompt for and get second point
            Console.Write("Enter X for second point: ");
            float point2X = float.Parse(Console.ReadLine());
            Console.Write("Enter Y for second point: ");
            float point2Y = float.Parse(Console.ReadLine());

            // calculate delta x and delta y
            float deltaX = point2X - point1X;
            float deltaY = point2Y - point1Y;

            // calculate distance and angle (in degrees)
            double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            double angle = Math.Atan2(deltaY, deltaX);
            angle *= 180 / Math.PI;

            // print distance and angle
            Console.WriteLine();
            Console.WriteLine("Distance between points: " + distance);
            Console.WriteLine("Angle between points: " + angle + " degrees");

            Console.WriteLine();
        }
    }
}

