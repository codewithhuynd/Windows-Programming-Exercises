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
            Console.WriteLine("=== Giải phương trình bậc nhất: ax + b = 0 ===");
            double a, b;
            try
            {
                Console.Write("Nhập a: ");
             a=double.Parse(Console.ReadLine());
                Console.Write("Nhập b: ");
                b=double.Parse(Console.ReadLine());
                if (a == 0)
                {
                    if (b == 0)
                        Console.WriteLine("Phương trình có vô số nghiệm.");
                    else
                        Console.WriteLine("Phương trình vô nghiệm.");
                }
                else
                {
                    double x = -b / a;
                    Console.WriteLine($"Phương trình có nghiệm x = {x}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }

            Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
            Console.ReadKey();
        }
    }
}
