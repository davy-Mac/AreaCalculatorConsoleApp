// Author David Maceda
// published Jan. 2020

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

            var shapeCount = 0;
            const int shapeLimit = 5;
            var invalidShape = false;
            
            while (shapeCount < shapeLimit && !invalidShape)
            {
                Console.WriteLine("choose one of three shapes: Square, Circle or Pentagon");
                var shape = Console.ReadLine().ToLower();

                double side = 0;
                if (shape=="square")
                {
                    Messenger tell = new Messenger();
                    tell.askSquareSideSize();
                    IAreaCalculator squareArea = new Square();
                    AreaCalculator areaCalculator = new AreaCalculator(squareArea);
                    side = double.Parse(Console.ReadLine());
                    Thread.Sleep(1000);

                    areaCalculator.squareArea(side);
                    shapeCount += 1;
                }

                else if (shape=="circle")
                {
                    Messenger tell = new Messenger();
                    tell.askCircleRadius();
                    IAreaCalculator circleArea = new Circle();
                    AreaCalculator areaCalculator = new AreaCalculator(circleArea);
                    var radius = double.Parse(Console.ReadLine());
                    Thread.Sleep(1000);

                    areaCalculator.circleArea(radius);
                    shapeCount += 1;
                }

                else if (shape == "pentagon")
                {
                    Messenger tell = new Messenger();
                    tell.askPentagonSide();
                    IAreaCalculator pentagonArea = new Circle();
                    AreaCalculator areaCalculator = new AreaCalculator(pentagonArea);
                    side = double.Parse(Console.ReadLine());
                    Thread.Sleep(1000);

                    areaCalculator.pentagonArea(side);
                    shapeCount += 1;
                }
                else
                {
                    invalidShape = true;
                    Messenger tell = new Messenger();
                    tell.invalidShapeMessage();

                }
            }   
        }

        static void tellTheUserAboutTheApp() // this can be implemented differently to follow single responsibility principle 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the area calculator app"
                              + Environment.NewLine + "please enter a shape name to calculate its area"
                              + Environment.NewLine + "you get to calculate 3 shapes e.g. square");
        }
    }
}
