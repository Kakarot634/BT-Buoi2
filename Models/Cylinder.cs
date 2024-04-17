using System;

namespace Models
{
    public class Cylinder : Circle1
    {
        public double Height { get; set;}
        public Cylinder()
        {
            Height = 1.0;
        }
        public Cylinder(double radius, double height) : base(radius)
        {
            this.Height = height;
        }
        public double GetVolume()
        {
            return GetArea() * Height;
        }
        public override string ToString()
        {
            return $"A Cylinder with radius={Radius} and height={Height}, which is subclass of{base.ToString()}";
        }
    }
}