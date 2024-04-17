using System;

namespace Models
{
    public class Circle1
    {
        public double Radius { get; set; }

        public Circle1()
        {
            Radius = 1.0;
        }
        public Circle1(double radius)
        {
            this.Radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public double GetCircumference()
        {
            return 2 * Math.PI * Radius;
        }
        public override string ToString()
        {
            return $"A Circle with radius={Radius}";
        }
    }
}