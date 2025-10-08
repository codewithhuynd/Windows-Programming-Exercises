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

            Console.WriteLine("Nhập họ, tên lót và tên. Xuất ra họ tên đầy đủ. ");
            Console.WriteLine();

            Console.Write("Nhập họ: ");
            string ho = Console.ReadLine(); 

            Console.Write("Nhập tên lót: ");
            string tenLot= Console.ReadLine();

            Console.Write("Nhập tên: ");
            string ten= Console.ReadLine();
            Console.WriteLine($"Họ và tên đầy đủ: {ho} {tenLot} {ten}");
            Console.WriteLine();
            Console.Write("Nhập vào họ tên đầy đủ:");
            string hoTen= Console.ReadLine();

            string[] arr = hoTen.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            if (arr.Length == 2)
            {
                Console.WriteLine($"Họ là {arr[0]}");
                Console.WriteLine($"Tên là {arr[1]}");

            }
            else
            {
                Console.WriteLine($"Họ là {arr[0]}");
                Console.Write("Tên lót là ");
                for(int i = 1; i < arr.Length - 1; i++)
                {
                    Console.WriteLine(arr[i]+" ");
                }
                Console.WriteLine($"Tên là {arr[arr.Length - 1]}");
            }

            Console.WriteLine("Nhập vào họ tên không đúng chuẩn: ");
            string hoTenSai= Console.ReadLine();
            string[] arrChuan=hoTenSai.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);

            string kq = "";
            for(int i = 0; i < arrChuan.Length; i++)
            {
                kq += arrChuan[i].Substring(0, 1).ToUpper() + arrChuan[i].Substring(1, arrChuan[i].Length - 1).ToLower()+" ";
            }

            Console.WriteLine(kq.Trim());
            Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
            Console.ReadKey();
        }
    }
}
