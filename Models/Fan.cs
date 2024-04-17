using System;

namespace Models
{
    public class Fan
        {
            public const int SLOW = 1;
            public const int MEDIUM = 2;
            public const int FAST = 3;

            private int speed;
            private bool isOn;
            private double radius;
            private string color;

            public Fan()
            {
                speed = SLOW;
                isOn = false;
                radius = 5;
                color = "Blue";
            }
            public int Speed
            {
                get { return speed; }
                set { speed = value; }
            }
            public bool IsOn
            {
                get { return isOn; }
                set { isOn = value; }
            }
            public double Radius
            {
                get { return radius; }
                set { radius = value; }
            }
            public string Color
            {
                get { return color; }
                set { color = value; }
            }
            public override string ToString()
            {
                if (isOn)
                {
                    return $"Speed: {speed}\nColor: {color}\nRadius: {radius}\nFan is on";
                }
                else
                {
                    return $"Color: {color}\nRadius: {radius}\nFan is off";
                }
            }
        }
}