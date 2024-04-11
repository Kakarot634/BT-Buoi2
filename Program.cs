using System;

namespace BTBUOI4
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Tính tổng các phần tử của mảng

            int[] numbers = new int[5];
            numbers[0] = 2;
            numbers[1] = 4;
            numbers[2] = 7;
            numbers[3] = 8;
            numbers[4] = 9;

            System.Console.WriteLine(numbers[0]);
            System.Console.WriteLine(numbers[2]);
            System.Console.WriteLine(numbers[3]);
            int total = 0;
            for (int y = 0; y < numbers.Length; y++)
            {
                total = total + numbers[y];
            }
            System.Console.WriteLine(total.ToString());

            //Tìm giá trị trong mảng

            string[] students = { "SonGoku", "Vegeta", "SonGohan", "Kiana Kaslana", "Raiden Mei", "Bronya", "Seele", "Stelle", "Acheron", "Vegito", "Gogeta" };
            System.Console.WriteLine("Enter a name's student:");
            string input_name = Console.ReadLine();
            bool isExist = false;
            for (int x = 0; x < students.Length; x++)
            {
                if (students[x].Equals(input_name))
                {
                    System.Console.WriteLine("Position of the student in the list " + input_name + " is: " + (x + 1));
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                System.Console.WriteLine("Not found" + input_name + " in the list.");
            }

            //Tìm giá trị lớn nhất trong mảng

            int size;
            int[] array;
            do
            {
                System.Console.WriteLine("Enter a size:");
                size = Int32.Parse(Console.ReadLine());
                if (size > 20)
                {
                    System.Console.WriteLine("Size should not exceed 20");
                }
            } while (size > 20);
            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                System.Console.WriteLine("Enter element" + (i + 1) + " : ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            System.Console.WriteLine("Property list: ");
            for (int j = 0; j < array.Length; j++)
            {
                System.Console.WriteLine(array[j] + "\t");
            }
            int max = array[0];
            int index = 1;
            for (var j = 0; j < array.Length; j++)
            {
                if (array[j] > max)
                {
                    max = array[j];
                    index = j + 1;
                }
            }
            System.Console.WriteLine("The largest property value in the list is " + max + " , at position " + index);

            // Thêm phần tử vào mảng

            int[] arr = { 1, 2, 3, 4, 5 };
            int insertIndex;
            int newValue;

            Console.Write("Nhập vị trí muốn chèn phần tử mới: ");
            while (!int.TryParse(Console.ReadLine(), out insertIndex) || insertIndex < 0 || insertIndex > arr.Length)
            {
                Console.WriteLine("Vị trí không hợp lệ. Vui lòng nhập lại.");
            }

            Console.Write("Nhập giá trị của phần tử mới: ");
            while (!int.TryParse(Console.ReadLine(), out newValue))
            {
                Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại.");
            }

            int[] newArr = new int[arr.Length + 1];

            Array.Copy(arr, newArr, insertIndex);

            for (int z = insertIndex; z < newArr.Length - 1; z++)
            {
                newArr[z + 1] = arr[z];
            }

            newArr[insertIndex] = newValue;

            Console.WriteLine("Mảng mới:");
            foreach (int element in newArr)
            {
                Console.Write(element + " ");
            }

            // Tìm phần tử lớn nhất trong mảng hai chiều
            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
            };

            int maxElement = matrix[0, 0];

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int a = 0; a < rows; a++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[a, j] > maxElement)
                    {
                        maxElement = matrix[a, j];
                    }
                }
            }

            Console.WriteLine("Phần tử lớn nhất trong mảng hai chiều là: " + maxElement);
        }
    }
}
