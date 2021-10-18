using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Square:Shapes
    {
        private double LengthOfSide;
        public Square(double LengthOfSide)
        {
            //This prints a message to the screen showing that we are created a new square
            //Console.WriteLine(String.Format("I'm initializing a new Square instance with a LengthOfSide value of {0}.", LengthOfSide));
            //This takes the Length of Side that we got and stores it into the Length of Side variable of the new square
            this.LengthOfSide = LengthOfSide;
        }
        public override double CalculateArea()
        {
            return (this.LengthOfSide * this.LengthOfSide);
        }
        public override double CalculatePerimeter()
        {
            return (this.LengthOfSide * 4);
        }
    }
}
