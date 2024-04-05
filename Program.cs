using System;

namespace BTBUOI3
{
    class Program
    {
        public static void DisplayRectangle()
        {
            int width = 5;
            int height = 3;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
        public static void DisplayTriangle()
        {
            int height = 5;
            for (int i = 1; i < height; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
        public static void DisplayTopLeftRightAngle()
        {
            int size = 3;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
        public static void DisplayTopRightRightAngle()
        {
            int size = 3;
            for (int i = 0; i < size; i++)
            {
                for(int j = 0; j < size - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
        public static void DisplayBottomLeftRightAngle()
        {
            int size = 3;
            for (int i = size; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
        public static void DisplayBottomRightRightAngle()
        {
            int size = 3;
            for (int i = size; i > 0; i--)
            {
                for (int j = size - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = i; k > 0; k--)
                {
                    Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
        public static void DisplayIsoscelesTriangle()
        {
            int height = 3;
            for (int i = 1; i <= height; i++)
            {
                for (int j = height - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                System.Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            //Hiển thị menu

            int choice = -1;
            while (choice != 0)
            {
                System.Console.WriteLine("Menu");
                System.Console.WriteLine("1. Draw the triangle");
                System.Console.WriteLine("2. Draw the square");
                System.Console.WriteLine("3. Draw the rectangle");
                System.Console.WriteLine("0. Exit");
                System.Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        System.Console.WriteLine("Draw the triangle");
                        System.Console.WriteLine("******");
                        System.Console.WriteLine("*****");
                        System.Console.WriteLine("****");
                        System.Console.WriteLine("***");
                        System.Console.WriteLine("**");
                        System.Console.WriteLine("*");
                        break;
                    case 2:
                        System.Console.WriteLine("Draw the square");
                        System.Console.WriteLine("* * * * * *");
                        System.Console.WriteLine("* * * * * *");
                        System.Console.WriteLine("* * * * * *");
                        System.Console.WriteLine("* * * * * *");
                        System.Console.WriteLine("* * * * * *");
                        System.Console.WriteLine("* * * * * *");
                        break;
                    case 3:
                        System.Console.WriteLine("Draw the rectangle");
                        System.Console.WriteLine("* * * * * *");
                        System.Console.WriteLine("* * * * * *");
                        System.Console.WriteLine("* * * * * *");
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        System.Console.WriteLine("No choice!");
                        break;
                }
            }
            
            //Kiểm tra số nguyên tố

            int number;
            System.Console.WriteLine("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 2)
            {
                System.Console.WriteLine((number + " is not a prime"));
            } 
            else
            {
                int i = 2;
                bool check = true;
                while (i < Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check)
                {
                    System.Console.WriteLine(number + " is a prime");
                }
                else
                {
                    System.Console.WriteLine(number + " is not a prime");
                }
            }

            //Hiển thị các loại hình

            while (true)
            {
                System.Console.WriteLine("Menu: ");
                System.Console.WriteLine("1. Hình chữ nhật");
                System.Console.WriteLine("2. Hình tam giác");
                System.Console.WriteLine("3. Góc vuông ở trên cùng bên trái");
                System.Console.WriteLine("4. Góc vuông ở trên cùng bên phải");
                System.Console.WriteLine("5. Góc vuông ở dưới cùng bên trái");
                System.Console.WriteLine("6. Góc vuông ở dưới cùng bên phải");
                System.Console.WriteLine("7. Hình tam giác cân");
                System.Console.WriteLine("0. Thoát");
                System.Console.WriteLine("Vui lòng chọn số từ menu: ");
                int choice1;
                if (int.TryParse(Console.ReadLine(), out choice1))
                {
                    switch (choice1)
                    {
                        case 1:
                            DisplayRectangle();
                            break;
                        case 2:
                            DisplayTriangle();
                            break;
                        case 3:
                            DisplayTopLeftRightAngle();
                            break;
                        case 4:
                            DisplayTopRightRightAngle();
                            break;
                        case 5:
                            DisplayBottomLeftRightAngle();
                            break;
                        case 6:
                            DisplayBottomRightRightAngle();
                            break;
                        case 7:
                            DisplayIsoscelesTriangle();
                            break;
                        case 0:
                            return;
                        default:
                            System.Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại!");
                            break;
                    }
                }
                else
                {
                    System.Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại!");
                }
                System.Console.WriteLine();
            }
        }
    }
}