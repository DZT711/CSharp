class checkPrimeNum
{
    /// <summary> 
    /// Đơn thể kiểm tra số nguyên tố 
    /// </summary> 
    /// <param name="n">Đầu vào: số nguyên n cần kiểm tra (tham số hình thức)</param> 
    /// <returns>true (là số nguyên tố), false (không là số nguyên tố)</returns> 
    /// <example> 
    /// n = 3 --> return = true 
    /// n = 6 --> return = false 
    /// </example> 
    public static bool laNguyenTo(int n)
    {
        int i;
        bool laNguyenTo;// cờ hiệu nguyên tố (true / false) 

        laNguyenTo = true; // Giả sử n là nguyên tố 
        for (i = 2; i * i <= n && laNguyenTo == true; i++)
        {
            if (n % i == 0) laNguyenTo = false;
        }
        if (n < 2) laNguyenTo = false;
        
        return laNguyenTo;
    }
    public static void Main(string[] args)
    {
        // Khai báo biến 
        int n;
        bool kq;

        // Nhập dữ liệu 
        Console.Write("Moi ban nhap n: ");
        n = int.Parse(Console.ReadLine());

        // Xử lý 
        kq = laNguyenTo(n);// Sử dụng đơn thể 

        // Xuất kết quả 
        if (kq)
            Console.WriteLine("So {0} la nguyen to.", n);
        else
            Console.WriteLine("So {0} khong la nguyen to.", n);
    }
}