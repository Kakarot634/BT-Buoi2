using System;
using System.Runtime.ConstrainedExecution;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace BTBuoi7
{
    class Books
    {
        public string Title { get; set; }
        public float Price { get; set; }
        class ReadWriteFileXML
        {
            private static string filePath = "D:/Downloads/Quản lí sản phẩm.csv";

            static void AddProduct()
            {
                System.Console.WriteLine("Enter product code: ");
                string productCode = Console.ReadLine();

                System.Console.WriteLine("Enter the product name:");
                string productName = Console.ReadLine();

                System.Console.WriteLine("Enter manufacturer: ");
                string manufacturer = Console.ReadLine();

                System.Console.WriteLine("Enter the price: ");
                string productPrice = Console.ReadLine();
                decimal price;
                while (!decimal.TryParse(productPrice, out price))
                {
                    System.Console.WriteLine("Price is not valid. Please re-enter: ");
                    productPrice = Console.ReadLine();
                }
                System.Console.WriteLine("Enter another description:");
                string description = Console.ReadLine();

                string productInfo = $"{productCode}, {productName}, {manufacturer}, {price}, {description}";

                try
                {
                    using (StreamWriter sw = new StreamWriter(filePath, true))
                    {
                        sw.WriteLine(productInfo);
                    }
                    System.Console.WriteLine("The product has been added successfully.");
                }
                catch (System.Exception ex)
                {
                    System.Console.WriteLine($"Error while adding product: {ex.Message}");
                }
            }
            static void DisplayProduct()
            {
                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] fields = line.Split(',');
                            if (fields.Length >= 5)
                            {
                                string productCode = fields[0];
                                string productName = fields[1];
                                string manufacturer = fields[2];
                                decimal productPrice = decimal.Parse(fields[3]);
                                string description = fields[4];

                                System.Console.WriteLine("Product code: ");
                                System.Console.WriteLine("Product name: ");
                                System.Console.WriteLine("Product manufacturer: ");
                                System.Console.WriteLine("Price: ");
                                System.Console.WriteLine("Description: ");
                                System.Console.WriteLine();
                            }
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    System.Console.WriteLine("Error when displaying product list");
                }
            }
            static void SearchProduct()
            {
                System.Console.WriteLine("Enter the product code need to be found: ");
                string searchProductCode = Console.ReadLine();

                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        bool found = false;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] fields = line.Split(',');
                            if (fields.Length >= 5)
                            {
                                string productCode = fields[0];
                                if (productCode.Equals(searchProductCode))
                                {
                                    string productName = fields[1];
                                    string manufacturer = fields[2];
                                    string productPrice = fields[3];
                                    string description = fields[4];

                                    System.Console.WriteLine("Product code: " + productCode);
                                    System.Console.WriteLine("Product name: " + productName);
                                    System.Console.WriteLine("Manufacturer: " + manufacturer);
                                    System.Console.WriteLine("Price: " + productPrice);
                                    System.Console.WriteLine("Description: " + description);
                                    System.Console.WriteLine();

                                    found = true;
                                    break;
                                }
                            }
                        }
                        if (!found)
                        {
                            System.Console.WriteLine("No product found with the entered code.");
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    System.Console.WriteLine($"Error when searching product: {ex.Message}");
                }
            }
            private static bool WriteToFile()
            {
                Books book = new Books();
                book.Title = "Đắc Nhân Tâm";
                book.Price = 123.5f;
                try
                {
                    XDocument xDoc = XDocument.Load("Books.xml");
                    XElement newBook = new XElement("book", new XElement("title", book.Title), new XElement("price", book.Price.ToString()));
                    xDoc.Element("Bookstore").Add(newBook);
                    xDoc.Save("Books.xml");
                    return true;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex);
                    return false;
                }
            }
            private static void ReadFromFile()
            {
                XmlTextReader reader = new XmlTextReader("Books.xml");
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            Console.Write("<" + reader.Name);
                            System.Console.WriteLine(">");
                            break;
                        case XmlNodeType.Text:
                            System.Console.WriteLine(reader.Value);
                            break;
                        case XmlNodeType.EndElement:
                            Console.Write("</" + reader.Name);
                            System.Console.WriteLine(">");
                            break;
                    }
                }
            }
            class ReadTextFileExample
            {
                public void ReadTextFile(string filepath)
                {
                    try
                    {
                        FileInfo file = new FileInfo(filepath);
                        if (!file.Exists)
                        {
                            throw new FileNotFoundException();
                        }
                        StreamReader reader = new StreamReader(filepath);
                        string line = "";
                        int sum = 0;
                        while ((line = reader.ReadLine()) != null)
                        {
                            System.Console.WriteLine(line);
                            sum += Int32.Parse(line);
                        }
                        reader.Close();
                        System.Console.WriteLine("Total: " + sum);
                    }
                    catch (System.Exception)
                    {
                        Console.Error.WriteLine("File not found or invalid content");
                    }
                }
                private static void CopyFileUsingFileInfo(FileInfo source, FileInfo des)
                {
                    source.CopyTo(des.FullName, true);
                }
                private static void CopyFileUsingStream(FileInfo source, FileInfo des)
                {
                    StreamReader reader = null;
                    StreamWriter writer = null;
                    try
                    {
                        reader = new StreamReader(source.FullName);
                        writer = new StreamWriter(des.FullName);
                        Char[] buffer = new Char[1024];
                        int length;
                        while ((length = reader.Read(buffer)) > 0)
                        {
                            writer.Write(buffer, 0, length);
                        }
                    }
                    finally
                    {
                        reader.Close();
                        reader.Dispose();
                        writer.Close();
                        writer.Dispose();
                    }
                }
                public static void Main(string[] args)
                {
                    // Sử dụng Lớp IndexOutOfRangeException 

                    try
                    {
                        List<char> characters = new List<char>();
                        characters.InsertRange(0, new Char[] { 'a', 'b', 'c', 'd', 'e', 'f' });
                        int value = characters[5];
                        System.Console.WriteLine(characters);
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        System.Console.WriteLine(ex);
                    }
                    System.Console.WriteLine("-----------------------------------------------");

                    // Tính tổng các số trong file text

                    System.Console.WriteLine("Please input file path");
                    string path = Console.ReadLine();
                    System.Console.WriteLine("File path: " + path);
                    ReadTextFileExample example = new ReadTextFileExample();
                    example.ReadTextFile(path);
                    System.Console.WriteLine("-----------------------------------------------");

                    // Copy các file có dung lượng lớn

                    System.Console.WriteLine("Enter source file: ");
                    string sourcePath = Console.ReadLine();
                    System.Console.WriteLine("Enter destination file: ");
                    string destinationPath = Console.ReadLine();

                    FileInfo source = new FileInfo(sourcePath);
                    FileInfo des = new FileInfo(destinationPath);
                    try
                    {
                        CopyFileUsingFileInfo(source, des);
                        System.Console.WriteLine("Copy completed");
                    }
                    catch (IOException e)
                    {
                        System.Console.WriteLine("Cannot Copy");
                        Console.Error.WriteLine(e.Message);
                    }
                    System.Console.WriteLine("-----------------------------------------------");

                    // Đọc ghi file XML

                    bool isWriten = WriteToFile();
                    if (isWriten)
                    {
                        ReadFromFile();
                    }
                    else
                    {
                        System.Console.WriteLine("Write data to file occur an error. Please try again !");
                    }
                    System.Console.WriteLine("-----------------------------------------------");

                    // Đọc file .csv

                    string filepath = "D:/Downloads/Mã Quốc Gia.csv";
                    try
                    {
                        using (StreamReader sr = new StreamReader(filepath))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                string[] fields = line.Split(',');
                                if (fields.Length >= 6)
                                {
                                    string countryCode = fields[4].Trim('"');
                                    string countryName = fields[5].Trim('"');

                                    System.Console.WriteLine($"{countryCode}: {countryName}");
                                }
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        System.Console.WriteLine($"An error occurred: {ex.Message}");
                    }

                    Console.ReadLine();

                    System.Console.WriteLine("-----------------------------------------------");

                    // Quản lý sản phẩm lưu ra file nhị phân

                    while (true)
                    {
                        System.Console.WriteLine("1. Add product");
                        System.Console.WriteLine("2. Display product list");
                        System.Console.WriteLine("3. Search product");
                        System.Console.WriteLine("4. Exit");
                        System.Console.WriteLine("Choose an option: ");
                        string choice = Console.ReadLine();
                        System.Console.WriteLine();

                        switch (choice)
                        {
                            case "1":
                                AddProduct();
                                break;
                            case "2":
                                DisplayProduct();
                                break;
                            case "3":
                                SearchProduct();
                                break;
                            case "4":
                                return;
                            default:
                                System.Console.WriteLine("Invalid option. Please select again");
                                break;
                        }
                        System.Console.WriteLine();
                    }
                }
            }
        }
    }
}