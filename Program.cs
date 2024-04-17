using System;
using Models;

namespace BTBuoi6
{
    class Program
    {
        public static int[] GenerateRandomNumbers(int count)
        {
            Random random = new Random();
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next();
            }
            return numbers;
        }
        public static void SelectionSort(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = 0; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = numbers[minIndex];
                numbers[minIndex] = numbers[i];
                numbers[i] = temp;
            }
        }

        public static void Main(string[] args)
        {
            // Lớp hình chữ nhật

            System.Console.WriteLine("Enter the width: ");
            double width = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the height: ");
            double height = Double.Parse(Console.ReadLine());
            Rectangle1 rectangle1 = new Rectangle1(width, height);
            System.Console.WriteLine("Your Rectangle \n" + rectangle1.Display());
            System.Console.WriteLine("Perimeter of the Rectangle: " + rectangle1.GetPerimeter());
            System.Console.WriteLine("Area of the Rectangle: " + rectangle1.GetArea());
            System.Console.WriteLine("---------------------------------------------");

            //Xây dựng class animal

            Cat cat = new Cat("20kg", "1.5", "Kitty");
            cat.PrintInfo();
            System.Console.WriteLine("---------------------------------------------");

            //Thực hành Static Method

            Student.Change();

            Student s1 = new Student(1, "Goku");
            Student s2 = new Student(2, "Kiana");
            Student s3 = new Student(3, "Acheron");
            s1.Display();
            s2.Display();
            s3.Display();
            System.Console.WriteLine("---------------------------------------------");

            //Lớp Fan

            Fan fan1 = new Fan();
            fan1.Speed = Fan.FAST;
            fan1.Radius = 10;
            fan1.Color = "Yellow";
            fan1.IsOn = true;

            Fan fan2 = new Fan();
            fan2.Speed = Fan.MEDIUM;
            fan2.Radius = 5;
            fan2.Color = "Blue";
            fan2.IsOn = false;

            System.Console.WriteLine("Fan 1:");
            System.Console.WriteLine(fan1.ToString());
            System.Console.WriteLine();

            System.Console.WriteLine("Fan 2:");
            System.Console.WriteLine(fan2.ToString());
            System.Console.WriteLine("---------------------------------------------");

            //Lớp StopWatch

            StopWatch stopWatch = new StopWatch();
            stopWatch.Start();

            int[] numbers = GenerateRandomNumbers(100000);
            SelectionSort(numbers);

            stopWatch.Stop();
            TimeSpan elapsedTime = stopWatch.GetElapsedTime();
            System.Console.WriteLine("Thời gian thực thi: " + elapsedTime.TotalMilliseconds + " ms");
            System.Console.WriteLine("---------------------------------------------");

            //Hệ các đối tượng hình học

            Shape shape = new Shape();
            System.Console.WriteLine(shape);
            shape = new Shape("red", false);
            System.Console.WriteLine(shape);

            Circle circle = new Circle();
            System.Console.WriteLine(circle);
            circle = new Circle(3.5);
            System.Console.WriteLine(circle);
            circle = new Circle(3.5, "indigo", false);
            System.Console.WriteLine(circle);

            Rectangle rectangle2 = new Rectangle();
            System.Console.WriteLine(rectangle2);

            rectangle2 = new Rectangle(2.3, 5.8);
            System.Console.WriteLine(rectangle2);

            rectangle2 = new Rectangle(2.5, 3.8, "orange", true);
            System.Console.WriteLine(rectangle2);

            Square square = new Square();
            Console.WriteLine(square);

            square = new Square(2.3);
            Console.WriteLine(square);

            square = new Square(5.8, "yellow", true);
            Console.WriteLine(square);
            System.Console.WriteLine("---------------------------------------------");

            //Lớp Circle và Lớp Cylinder

            Circle1 circle1 = new Circle1();
            System.Console.WriteLine(circle1.ToString());
            System.Console.WriteLine("Area: " + circle1.GetArea());
            System.Console.WriteLine("Circumference: " + circle1.GetCircumference());

            Cylinder cylinder = new Cylinder();
            System.Console.WriteLine(cylinder.ToString());
            System.Console.WriteLine("Area: " + cylinder.GetArea());
            System.Console.WriteLine("Circumference: " + cylinder.GetCircumference());
            System.Console.WriteLine("Volume: " + cylinder.GetVolume());
            System.Console.WriteLine("---------------------------------------------");

            //Lớp Point2D và Lớp Point3D

            Point2D point2D = new Point2D();
            System.Console.WriteLine(point2D);
            point2D = new Point2D(2.0f, 1.5f);
            System.Console.WriteLine(point2D);

            Point3D point3D = new Point3D();
            System.Console.WriteLine(point3D);
            point3D = new Point3D(5.0f, 7.0f, 10.0f);
            System.Console.WriteLine(point3D);
        }
    }
}