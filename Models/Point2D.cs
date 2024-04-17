using System;

namespace Models
{
    public class Point2D
    {
        private float x = 0.0f;
        private float y = 0.0f;

        public Point2D()
        {

        }

        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float GetX()
        {
            return x;
        }
        public void SetX(float x)
        {
            this.x = x;
        }
        public float GetY()
        {
            return y;
        }
        public void SetY(float y)
        {
            this.y = y;
        }
        public void SetXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float[] GetXY()
        {
            float[] array = new float[2];
            return array;
        }
        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}