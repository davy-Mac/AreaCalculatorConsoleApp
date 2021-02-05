using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace AreaCalculatorConsoleApp
{
    class AreaCalculator
    {
        private IAreaCalculator _areaCalculator;

        public AreaCalculator(IAreaCalculator areaCalculator)
        {
            _areaCalculator = areaCalculator;
        }

        public void squareArea(double side)
        {
            Console.WriteLine("The area of a square with sides of: " + side + " centimeters"
                              +Environment.NewLine + " is: " + _areaCalculator.CalcArea(side));
        }

        public void circleArea(double radius)
        {
            Console.WriteLine("The area of a circle with a radius of " + radius + " centimeters"
                              + Environment.NewLine + " is: " + _areaCalculator.CalcArea(radius));
        }
        public void pentagonArea(double side)
        {
            Console.WriteLine("The area of a Regular Pentagon with sides of: " + side + " centimeters"
                              + Environment.NewLine + " is: " + _areaCalculator.CalcArea(side));
            
        }
    }
}
