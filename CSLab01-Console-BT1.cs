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
            Console.WriteLine("Hãy nhập vào tên bạn: ");
            string ten = Console.ReadLine();
            Console.WriteLine($"Xin chào {ten}");
        }
    }
}
