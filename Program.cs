using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Giải Phương Trình Bậc 2: A.X^2 + B.X + C = 0");
            Console.Write("Nhập A: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập B: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập C: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
            else if (delta > 0)
            {
                double x1 = -b + Math.Sqrt(delta) / 2 * a;
                double x2 = -b - Math.Sqrt(delta) / 2 * a;
                Console.WriteLine("Phương trình có hai nghiệm phân biệt: ");
                Console.Write($"x1 = {x1}; x2 ={x2}");
            }
            else
            {
                Console.WriteLine("Phương trình có nghiệm kép: ");
                Console.Write($"x = {-b / 2 * a}");
            }


        }
    }
}
