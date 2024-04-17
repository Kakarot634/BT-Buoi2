using System;

namespace Models
{
    public class Rectangle1
        {
            double width, height1;

            public Rectangle1(double width, double height1)
            {
                this.width = width;
                this.height1 = height1;
            }

            public double GetArea()
            {
                return this.width * this.height1;
            }
            public double GetPerimeter()
            {
                return (this.width + this.height1) * 2;
            }
            public String Display()
            {
                return "Rectangle{" + "width=" + width + ", height=" + height1 + "}";
            }
        }
}