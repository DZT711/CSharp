class outputNums
{
    public static void Main(string[] args)
    {
        // Khai báo biến
        int n, i;
        // Nhập dữ liệu
        Console.Write("Moi ban nhap so nguyen duong n: ");
        n = int.Parse(Console.ReadLine());
        // Xử lý
        // Xuất kết quả
        // Tu 1 den n
        Console.Write("Cac so nguyen duong tu 1 den {0}: ", n);
        for (i = 1; i <= n; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
        // Tu n ve 1
        Console.Write("Cac so nguyen duong tu {0} ve 1: ", n);
        for (i = n; i >= 1; i--)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
        // Cac so chan tu 1 den n
        Console.Write("Cac so chan tu 1 den {0}: ", n);
        for (i = 2; i <= n; i = i + 2)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
        // Cac so le tu n ve 1
        Console.Write("Cac so chan tu 1 den {0}: ", n);
        for (i = (n % 2 == 1) ? n : n - 1; i >= 1; i = i - 2)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}