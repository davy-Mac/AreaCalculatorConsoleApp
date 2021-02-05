using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculatorConsoleApp
{
    class Messenger
    {
        

        public void askSquareSideSize()
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter the side size of the square in centimeters");
        }

        public void askCircleRadius()
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter the radius in centimeters");
        }

        public void askPentagonSide()
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter the side length of a Regular Pentagon in centimeters");
        }

        public void invalidShapeMessage()
        {
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("the shape you entered is not yet supported...");
        }
    }
}
