using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập vào số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Nhập vào các phần tử:");
            int sum = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
                sum += arr[i];
            }
            Console.WriteLine($"Tổng của mảng là: {sum}");
            Console.WriteLine($"Giá trị nhỏ nhất của mảng là: {min}");
            Console.WriteLine($"Giá trị lớn nhất của mảng là: {max}");

            Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
            Console.ReadKey();
        }
    }
}
