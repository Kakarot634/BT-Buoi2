using System;
using Model;

namespace BTBuoi7
{
    class AbstractAndInterfaceTests
    {
        public static void Main(string[] args)
        {
            //Lớp Animal và interface Edible

            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();

            foreach (Animal animal in animals)
            {
                System.Console.WriteLine(animal.MakeSound());
                if (animal is Chicken)
                {
                    Edible edible = (Chicken)animal;
                    System.Console.WriteLine(edible.HowToEat());
                }
            }

            Fruit[] fruits = new Fruit[2];
            fruits[0] = new Orange();
            fruits[1] = new Apple();
            foreach (Fruit fruit in fruits)
            {
                System.Console.WriteLine(fruit.HowToEat());
            }
            System.Console.WriteLine("-------------------------------------------");

            //Triển khai interface "IComparable" cho các lớp hình học

            ComparableCircle[] circles = new ComparableCircle[3];
            circles[0] = new ComparableCircle(3.6);
            circles[1] = new ComparableCircle();
            circles[2] = new ComparableCircle(3.5, "indigo", false);

            System.Console.WriteLine("Pre-sorted:");
            foreach (ComparableCircle circle in circles)
            {
                System.Console.WriteLine(circle);
            }

            Array.Sort(circles);

            System.Console.WriteLine("After-sorted:");
            foreach (ComparableCircle circle1 in circles)
            {
                System.Console.WriteLine(circle1);
            }
            System.Console.WriteLine("-------------------------------------------");

            //Triển khai interface "IComparer" để so sánh các lớp hình học

            Circle[] circles2 = new Circle[3];
            circles2[0] = new Circle(3.6);
            circles2[1] = new Circle();
            circles2[2] = new Circle(3.5, "indigo", false);

            System.Console.WriteLine("Pre-sorted:");
            foreach (Circle circle3 in circles2)
            {
                System.Console.WriteLine(circle3);
            }

            IComparer<Circle> circleComparator = new CircleComparer();
            Array.Sort(circles2, circleComparator);

            System.Console.WriteLine("After-sorted:");
            foreach (Circle circle3 in circles2)
            {
                System.Console.WriteLine(circle3);
            }
            System.Console.WriteLine("-------------------------------------------");

            //Triển khai interface "Resizeable" cho các lớp hình học
            Circle circles3 = new Circle(5.0);
            Rectangle rectangle = new Rectangle(4.0, 3.0);
            Square square = new Square(5.0);

            System.Console.WriteLine("Circle before resizing:");
            System.Console.WriteLine($"Radius: {circles3.GetRadius()}");
            circles3.Resize(150);
            System.Console.WriteLine("Circle after resizing:");
            System.Console.WriteLine($"Radius: {circles3.GetRadius()}");
            System.Console.WriteLine($"Area: {circles3.GetArea()}");

            System.Console.WriteLine("-------------------------------------------");

            //Triển khai interaface "IColorable" cho các lớp hình học

            Square square1 = new Square(5);
            square.GetArea();
            
            if (square1 is IColorable)
            {
                ((IColorable)square1).HowToColor();
            }
            else
            {
                System.Console.WriteLine("Square does not support coloring");
            }
        }
    }
}