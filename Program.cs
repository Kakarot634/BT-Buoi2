using System;
using System.Data;

namespace Baitapbuoi2
{
    class Program
    {
        private static string[] units = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifthteen", "sixteen", "seventeen", "eighteen", "nineteen"};
        private static string[] tens = {"", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};
        private static string[] thousands = {"", "thousand", "million", "billion", "trillion", "quadrillion", "quintillion"};
        private static string ConvertNumberToWords(long number)
        {
        if (number == 0)
        {
            return "zero";
        }
        string words = "";
        for(int i = 0; number > 0; i++)
        {
            if (number % 1000 != 0)
            {
                string part = ConvertThreeDigitNumberToWords((int)(number % 1000));
                words = part + " " + thousands[i] + " " + words;
            }
            number /= 1000;
        }
        return words.Trim();
        }
        private static string ConvertThreeDigitNumberToWords(int number)
        {
            string words = "";
            if (number % 100 < 20)
            {
                words = units[number % 100];
                number /= 100;
            }
            else
            {
                words = units[number % 10];
                number /= 10;

                words = tens[number % 10];
                number /= 10;
            }
            if (number == 0)
            {
                return words;
            }
            return units[number] + " hundred " + words;
        }
        public static void Main(string[] args)
        {
            // Hiển thị thời gian hiện tại
            DateTime localDate = DateTime.Now;
            System.Console.WriteLine("Datetime Now is: " + localDate);

            // Sử dụng toán tử 

            float width;
            float height;
            Console.Write("Enter width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = float.Parse(Console.ReadLine());
            float area = width * height;
            System.Console.WriteLine("Area is: " + area);
            
            // Hiển thị lời chào
            System.Console.WriteLine("Enter your name: ");
            string yourName = Console.ReadLine();
            System.Console.WriteLine("Hello " + yourName);

            //Chuyển đổi tiền tệ
            System.Console.WriteLine("Ứng dụng chuyển đổi tiền tệ");
            double exchangeRate = 23000;

            Console.Write("Nhập số tiền muốn chuyển đổi (USD): ");
            double amountUSD = double.Parse(Console.ReadLine());

            double convertedAmountBTC = amountUSD * exchangeRate;

            Console.WriteLine($"{amountUSD} USD = {convertedAmountBTC} BTC");

            //Giải phương trình bậc nhất
            System.Console.WriteLine("Linear Equation Resolver");
            System.Console.WriteLine("Given a equation as 'a * x + b = 0', please enter constants: ");

            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a != 0)
            {
                double solution = -b / a;
                Console.Write("The solution is: {0}!", solution);
            }
            else
            {
                Console.Write("Nod solution!");
            }

            //Tính chỉ số cân nặng
            double height1;
            double weight1;

            System.Console.WriteLine("Please enter your height");
            height1 = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Please enter your weight");
            weight1 = float.Parse(Console.ReadLine());

            double bmi = weight1 / Math.Pow(height1, 2);
            bmi = Math.Round(bmi, 1);

            Console.Write("BMI: " + bmi);
            if (bmi < 18)
            {
                System.Console.WriteLine(" Underweight");
            } else if (bmi < 25.0)
            {
                System.Console.WriteLine(" Normal");
            } else if (bmi < 30.0)
            {
                System.Console.WriteLine(" Overweight");
            } else
            {
                System.Console.WriteLine(" You so fvcking fat!");
            }

            //Ứng dụng đọc số thành chữ
            System.Console.WriteLine("Chương trình đọc số thành chữ");

            Console.Write("Nhập số cần đọc: ");
            long number = long.Parse(Console.ReadLine());

            string words = ConvertNumberToWords(number);

            System.Console.WriteLine($"Số {number} đọc thành chữ là: {words}");
        }
    }
}
