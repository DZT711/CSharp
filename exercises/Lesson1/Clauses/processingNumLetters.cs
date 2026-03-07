class processingNumLetters
{
    public static void Main(string[] args)
    {
        // Khai báo biến
        int n, n1;
        int demcs, tongcs, csmax;
        // Nhập dữ liệu
        Console.Write("Moi ban nhap so nguyen n: ");
        n = int.Parse(Console.ReadLine());
        // Xử lý
        n1 = n;
        demcs = 0; // Đếm chữ số
        tongcs = 0;// Tổng chữ số
                   // chữ số nhỏ nhất ban đầu
                   // (không tồn tại trong tập chữ số [0,9])
        csmax = -1;
        // Duyệt các chữ số của n từ phải qua trái
        while (n1 != 0)
        {
            int cs = n1 % 10; // chữ số tại vị trí cuối
            demcs++;
            tongcs += cs;
            if (csmax == -1)// nếu chưa tồn tại
                csmax = cs;
            else// đã tồn tại
            {
                // Chưa tối ưu
                if (csmax < cs) csmax = cs;
            }
            n1 = n1 / 10;// dịch n qua phải
        }
        // Xuất kết quả
        Console.WriteLine("So {0} co {1} chu so, tong chu so la {2}, chu so lon nhat la {3}.", n, demcs, tongcs, csmax);
    }
}

