using System;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace AreaCalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            tellTheUserAboutTheApp();
            Console.ForegroundColor = oldColor;

            int shapeCount = 0;
            int shapeLimit = 3;
            string shape = null;

            double side1 = 0;
            double side2 = 0;
            double shapeBase = 0;
            double radius = 0;
            bool invalidShape = false;

            double squareAreaResult = 0;
            double circleAreaResult = 0;
            double pentagonAreaResult = 0;

            while (shapeCount < shapeLimit && !invalidShape)
            {
                Console.WriteLine("choose one of three shapes: Square, Circle or Pentagon");
                shape = Console.ReadLine().ToLower();

                if (shape=="square")
                {
                    askSquareSideSize();
                    side1 = double.Parse(Console.ReadLine());
                    Thread.Sleep(1000);
                    calculateSquareArea(side1);
                    shapeCount += 1;
                    Console.WriteLine("The area of a square with sides of: " + side1
                                      + Environment.NewLine + "is: " + squareAreaResult + "centimeters");
                }

                else if (shape=="circle")
                {
                    askCircleRadius();
                    radius = double.Parse(Console.ReadLine());
                    Thread.Sleep(1000);
                    calculareCircleArea(radius);
                    shapeCount += 1;
                    Console.WriteLine("The area of a circle with a radius of " + radius
                                      + Environment.NewLine + "is " + circleAreaResult + "centimeters");
                }

                else if (shape == "pentagon")
                {
                    askPentagonSide();
                    side1 = double.Parse(Console.ReadLine());
                    Thread.Sleep(1000);
                    calcPentagonArea(side1);
                    shapeCount += 1;
                    Console.WriteLine("The area of a Reegular Pentagon with sides of: " + side1
                                      + Environment.NewLine + "is " + pentagonAreaResult + "centimeters");
                }

            }

            //calc the area of a Square
            double calculateSquareArea(double s1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                squareAreaResult = side1 * side1;

                return squareAreaResult;
            }

            // calc the area of a circle
            double calculareCircleArea(double r1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                circleAreaResult = (3.14) * radius * radius;

                return circleAreaResult;
            }

            // calc the area of a pentagon
            double calcPentagonArea(double s2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                float area;
                pentagonAreaResult = (float)(Math.Sqrt(5 * (5 + 2 *(Math.Sqrt(5)))) * s2 * s2) / 4;

                return pentagonAreaResult;
            }
        }

        static void tellTheUserAboutTheApp()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the area calculator app"
                                    +Environment.NewLine + "please enter a shape name to calculate its area"
                                    +Environment.NewLine + "you get to calculate 3 shapes e.g. square");
        }

        static void askSquareSideSize()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter the side size of the square in centimeters");
        }

        static void askCircleRadius()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter the radius in centimeters");
        }

        static void askPentagonSide()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter the side length of a Regular Pentagon in centimeters");
        }

    }
}
