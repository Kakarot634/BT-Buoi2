using System;

namespace Models
{
    public class Point3D : Point2D
    {
        private float z = 0.0f;

        public Point3D()
        {

        }
        public Point3D(float x, float y, float z) :base(x, y)
        {
            this.z = z;
        }
        public float GetZ()
        {
            return z;
        }
        public void SetZ(float z)
        {
            this.z = z;
        }
        public void SetXYZ(float x, float y, float z)
        {
            SetXY(x ,y);
            this.z = z;
        }
        public float[] GetXYZ()
        {
            float[] array = new float[3];
            return array;
        }
        public override string ToString()
        {
             return "(" + GetX() + ", " + GetY() + ", " + z + ")";
        }
    }
}