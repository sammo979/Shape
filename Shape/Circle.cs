using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Circle:Shapes
    {
        private double radius;
        public Circle(double radius)
        {
            // This prints a message to the screen showing that we are create a new circle
            //Console.WriteLine("Im initializing a new Circle instance with a radius value of" + radius);
            // This takes the radius that we got and stores it into the radius variable of the new circle
            this.radius = radius;
        }
        public override double CalculateArea()
        {
            return (Math.PI * (this.radius * this.radius));
        }
        public override double CalculatePerimeter()
        {
            return (Math.PI * (2 * this.radius));
        }
    }
}
