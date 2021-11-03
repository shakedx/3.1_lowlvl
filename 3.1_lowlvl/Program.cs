using System;

namespace Kolesnikov_3._2_baza
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите n:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите m:");
                int m = int.Parse(Console.ReadLine());
                double R = 0;
                int count = m;
                {
                    R = m * m - 2 * m * n + n * n;
                }
                Console.WriteLine($"R={R}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}