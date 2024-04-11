using System;

namespace BTBUOI5
{
    class Program
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (9.0 / 5) * celsius + 32;
            return fahrenheit;
        }

        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = (5.0 / 9) * (fahrenheit - 32);
            return celsius;
        }

        public static int MinValue(int[] array)
        {
            int min = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }
            return index;
        }
        public static int[] DeleteElementAtIndex(int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];
            Array.Copy(array, newArray, array.Length - 1);
            Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);
            return newArray;
        }
        public static int CountCharacterOccurrences(string input, char character)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == character)
                {
                    count++;
                }
            }
            return count;
        }
        public static void Main(String[] args)
        {
            // Chuyển đổi nhiệt độ

            double fahrenheit;
            double celsius;
            int choice;

            do
            {
                Console.WriteLine("Menu.");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter fahrenheit: ");
                        fahrenheit = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Fahrenheit to Celsius: " + FahrenheitToCelsius(fahrenheit));
                        break;
                    case 2:
                        Console.WriteLine("Enter Celsius: ");
                        celsius = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Celsius to Fahrenheit: " + CelsiusToFahrenheit(celsius));
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (choice != 0);

            //Tìm giá trị nhỏ nhất trong mảng sử dụng phương thức

            int[] arr = { 4, 12, 14, 6, 15, 19, 20, 3, 10 };
            int index = MinValue(arr);
            System.Console.WriteLine("The smallest element in array is: " + arr[index]);

            // Viết phương thức xóa phần tử khỏi mảng

            int[] newArray3 = DeleteElementAtIndex(arr, 3);
            System.Console.WriteLine("Array after delete at any index: ");
            foreach (int num in newArray3)
            {
                Console.Write(num + " ");
            }
            System.Console.WriteLine();
            
            //Viết phương thức đếm số lần xuất hiện của ký tự trong chuỗi

            Console.Write("Nhập chuỗi: ");
            string input = Console.ReadLine();
            Console.Write("Nhập ký tự cần đếm: ");
            char characterToCount = Console.ReadKey().KeyChar;
            int occurenceCount = CountCharacterOccurrences(input, characterToCount);
            System.Console.WriteLine($"\nSố lần xuất hiện ký tự '{characterToCount}' trong chuỗi '{input}' là '{occurenceCount}' lần.");
        }
    }
}
