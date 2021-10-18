using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    public class Ellipse:Shapes
    {
        private double SemiMajorAxis, SemiMinorAxis;
        public Ellipse(double SemiMajorAxis, double SemiMinorAxis)
        {
            // This prints a message to the screen showing that we are create a new ellipse
            //Console.WriteLine("Im initializing a new Ellipse instance with a Semi Major Axis value of" + SemiMajorAxis + "and Semi Minor Axis value of" + SemiMinorAxis + ".");
            // This takes the Semi Major Axis that we got and stores it into the Height variable of the new ellipse
            this.SemiMajorAxis = SemiMajorAxis;
            // This takes the Semi Minor Axis that we got and stores it into the Width variable of the new ellipse
            this.SemiMinorAxis = SemiMinorAxis;
        }
        public override double CalculateArea()
        {
            return (Math.PI * this.SemiMajorAxis * this.SemiMinorAxis);
        }
        public override double CalculatePerimeter()
        {
            return (2 * Math.PI * Math.Sqrt((((this.SemiMajorAxis * this.SemiMajorAxis) + (this.SemiMinorAxis * this.SemiMinorAxis)) / 2)));
        }
    }
}
