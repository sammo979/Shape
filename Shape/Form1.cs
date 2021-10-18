using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shape
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Square_Calculate_Click(object sender, EventArgs e)
        {
            var square1 = new Square(double.Parse(square_length.Text));
            double area_value = square1.CalculateArea();
            double perimeter_value = square1.CalculatePerimeter();
            area.Text = area_value.ToString();
            perimeter.Text = perimeter_value.ToString();
        }
        private void Ellipse_Calculate_Click(object sender, EventArgs e)
        {
            var ellipse1 = new Ellipse(double.Parse(semi_major_axis.Text), double.Parse(semi_minor_axis.Text));
            double area_value = ellipse1.CalculateArea();
            double perimeter_value = ellipse1.CalculatePerimeter();
            area.Text = area_value.ToString();
            perimeter.Text = perimeter_value.ToString();
        }
        private void Circle_Calculate_Click(object sender, EventArgs e)
        {
            var circle1 = new Circle(double.Parse(circle_radius.Text));
            double area_value = circle1.CalculateArea();
            double perimeter_value = circle1.CalculatePerimeter();
            area.Text = area_value.ToString();
            perimeter.Text = perimeter_value.ToString();
        }
        private void Rectangle_Calculate_Click(object sender, EventArgs e)
        {
            var rectangle1 = new Rectangle(double.Parse(rectangle_length.Text), double.Parse(rectangle_width.Text));
            double area_value = rectangle1.CalculateArea();
            double perimeter_value = rectangle1.CalculatePerimeter();
            area.Text = area_value.ToString();
            perimeter.Text = perimeter_value.ToString();
        }
        private void Pentagon_Calculate_Click(object sender, EventArgs e)
        {
            var pentagon1 = new Pentagon(double.Parse(pentagon_side.Text), double.Parse(pentagon_diagonal.Text));
            double area_value = pentagon1.CalculateArea();
            double perimeter_value = pentagon1.CalculatePerimeter();
            area.Text = area_value.ToString();
            perimeter.Text = perimeter_value.ToString();
        }
    }
}
