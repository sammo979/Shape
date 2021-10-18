using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Pentagon:Shapes
    {
        private double side, diagonal;
        public Pentagon(double side, double diagonal)
        {
            // This prints a message to the screen showing that we are create a new Pentagon
            //Console.WriteLine("Im initializing a new Pentagon instance with a Side value of" + side + "and Diagonal value of" + diagonal + ".");
            // This takes the side that we got and stores it into the side variable of the new pentagon
            this.side = side;
            // This takes the diagonal that we got and stores it into the diagonal variable of the new pentagon
            this.diagonal = diagonal;
        }
        public override double CalculateArea()
        {
            //a^2
            double aSquared = this.side * this.side;
            // square root of 5
            double b = Math.Sqrt(5);
            // 2 times B
            double c = 2 * b;
            // 5 plus c
            double d = 5 + c;
            // 5 times d
            double e = 5 * d;
            // square root of e
            double f = Math.Sqrt(e);
            // 1/4 times f times aSquared
            double area = 0.25 * f * aSquared;
            return area;
        }
        public override double CalculatePerimeter()
        {
            return 5 * this.side;
        }
    }
}
