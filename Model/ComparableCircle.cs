using System;

namespace Model
{
    public class ComparableCircle : Circle, IComparable<ComparableCircle>
    {
        public ComparableCircle(){}
        public ComparableCircle(double radius) : base(radius){}
        public ComparableCircle(double radius, string color, bool filled) : base(radius, color, filled){}

        public int CompareTo(ComparableCircle o)
        {
            if (GetRadius() > o.GetRadius())
            {
                return 1;
            }
            else if(GetRadius() < o.GetRadius())
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}