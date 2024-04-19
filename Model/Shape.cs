using System;

namespace Model
{
    public class Shape
    {
        private string color = "green";
        private bool filled = true;
        public Shape()
        {

        }
        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }
        public string GetColor()
        {
            return color;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public bool isFilled()
        {
            return filled;
        }
        public void SetFilled(bool filled)
        {
            this.filled = filled;
        }
        public override string ToString()
        {
            return "A shape with color of "
            + GetColor()
            + " and "
            + (isFilled() ? "filled" : "not filled");
        }
    }
}