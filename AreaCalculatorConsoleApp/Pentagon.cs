using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculatorConsoleApp
{
    class Pentagon : IAreaCalculator
    {
        //public double side { get; set; }

        public double CalcArea(double side)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            float area;
            area = (float)(Math.Sqrt(5 * (5 + 2 * (Math.Sqrt(5)))) * side * side) / 4;

            return area;
        }
    }
}
