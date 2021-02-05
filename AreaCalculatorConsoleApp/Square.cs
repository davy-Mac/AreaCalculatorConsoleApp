using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculatorConsoleApp
{
    class Square : IAreaCalculator
    {
        //public double Side { get; set; }

        public double CalcArea(double side)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            double squareAreaResult;
            squareAreaResult = side * side;

            return squareAreaResult;
        }

    }
}
