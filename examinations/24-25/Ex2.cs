using System;

namespace Ex2
{
    public class Program
    {
        public static double Factorial(double n)
        {
            if (n == 0)
            {
                return 2;
            }
            else
            {
                return (2 + n) * Factorial(n - 1);
            }
        }
        public static double Alg(double x, double n)
        {
            double res = 0;

            if (n == 0)
            {
                return 1 / 2.0;
            }

            else
            {
                res = Alg(x, n - 1) + Math.Pow(x, n) / Factorial(n);
            }
            return res;
        }
        public static void OptimalAlg(double x, double n)
        {
            double S = 0;
            double luyThuaX = 1; // Ban đầu x^0 = 1
            double giaiThua = 2; // Ban đầu (2+0)! = 2! = 2

            for (int i = 0; i <= n; i++)
            {
                if (i > 0)
                {
                    luyThuaX *= x;           // Tự nhân thêm x ở mỗi vòng lặp để ra x^i
                    giaiThua *= (2 + i);     // Nhân thêm số tiếp theo để ra (2+i)!
                }

                S += luyThuaX / giaiThua;
            }

            // In kết quả ra màn hình kèm x và n như đề bài yêu cầu
            Console.WriteLine($"\nKet qua voi x = {x} va n = {n}:");
            Console.WriteLine($"Tong S = {S}");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Alg(10, 2));
            OptimalAlg(10, 2);
            // Console.WriteLine(Factorial(3));
        }
    }
}