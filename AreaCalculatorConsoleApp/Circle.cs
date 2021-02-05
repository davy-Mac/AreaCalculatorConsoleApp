using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculatorConsoleApp
{
    class Circle : IAreaCalculator
    {
        //public double radius { get; set; }
        public double CalcArea(double radius)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            double area;
            area = (3.14) * radius * radius;

            return area;
        }
    }
}
