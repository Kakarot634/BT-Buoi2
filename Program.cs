using System;
using System.Data;

namespace Baitapbuoi2
{
    class Program
    {
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
        }
    }
}
