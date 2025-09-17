namespace Baitap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.OutputEncoding = System.Text.Encoding.UTF8;
             Console.InputEncoding = System.Text.Encoding.UTF8;
             Console.WriteLine("Nhập vào tên của bạn:");
             string name = Console.ReadLine().Trim();
             Console.WriteLine($"Xin chào bạn {name}");
             Console.ReadKey();
        }
    }
}
