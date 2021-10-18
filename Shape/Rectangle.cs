using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Rectangle:Shapes
    {
        private double Width, length;
        public Rectangle(double length, double Width)
        {
            // This prints a message to the screen showing that we are create a new rectangle
            //Console.WriteLine("I'm initializing a new Rectangle instance with a Height value of" + Height + "and Width vale of" + Width + ".");
            // This takes the Height that we got and stores it into the Height variable of the new rectangle
            this.length = length;
            // This takes the Width that we got and stores it into the Width variable of the new rectangle
            this.Width = Width;
        }
        public override double CalculateArea()
        {
            return (this.Width * this.length);
        }
        public override double CalculatePerimeter()
        {
            return (2 * this.Width + 2 * this.length);
        }

    }
}
