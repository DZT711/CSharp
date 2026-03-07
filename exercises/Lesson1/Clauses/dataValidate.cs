class dataValidate
{
    public static void Main(string[] args)
    {
        // Khai báo biến 
        int n;

        // Nhập dữ liệu (có kiểm tra) 
        do
        {
            Console.Write("Moi ban nhap so n (|n|<=200): ");
            n = int.Parse(Console.ReadLine());
        } while (n < -200 || n > 200);
        // cho tới khi n>=-200 và n<=200 (|n|<=200, -200 <= n <= 200) 

        // Xuất kết quả 
        Console.WriteLine("Ban da nhap so {0} thoa yeu cau de bai.", n);
    }
}