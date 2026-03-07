public class IO_OneDimensionArr
{
    // tạo dãy số nguyên có giá trị trong đoạn vmin, vmax 
    public static void taoDay(ref int[] a, int n, int vmin, int vmax)
    {
        Random rand = new Random();
        a = new int[n];
        for (int i = 0; i <= a.Length - 1; i++)
        {
            a[i] = rand.Next(vmin, vmax);
        }
    }

    // soPhanTu: qui định số lượng phần tử trên mỗi dòng 
    // soPhanTu.Length qui định số lượng dòng 
    public static void taoMang(ref int[][] a, int[] soPhanTu, int vmin, int vmax)
    {
        Random rand = new Random();
        // Tạo mảng a chứa nd phần tử mà mỗi phần tử là mảng 1 chiều 
        a = new int[soPhanTu.Length][];
        // Duyệt mảng a 
        // Mỗi phần tử trong a tạo nc phần tử ngẫu nhiên trong [vmin, vmax] 
        for (int i = 0; i <= a.Length - 1; i++)
        {
            a[i] = new int[soPhanTu[i]];
            // Duyệt từng phần tử trong a[i] 
            for (int j = 0; j <= a[i].Length - 1; j++)
            {
                a[i][j] = rand.Next(vmin, vmax);
            }
        }
    }

    public static void xuatMang(int[][] a)
    {
        Console.WriteLine("Cac gia tri trong mang: ");
        // Xét từng dãy A[0], A[1], ..., A[n-1] 
        for (int i = 0; i <= a.Length - 1; i++)
        {
            Console.Write("A[{0}]: ", i);

            // In dãy A[i] 
            for (int j = 0; j <= a[i].Length - 1; j++)
            {
                Console.Write("{0} ", a[i][j]);
            }
            Console.WriteLine();// Xuống dòng 
        }
    }

    public static void Main(string[] args)
    {
        // Khai báo mảng 
        int[][] a1 = null;
        int n;
        int[] dodai = null;

        // Nhập số phần tử cho mảng A 
        Console.Write("Moi ban nhap so phan tu cho mang: ");
        n = int.Parse(Console.ReadLine());
        // Tạo số lượng phần tử ngẫu nhiên cho từng A[i] 
        taoDay(ref dodai, n, 3, 10);
        // Tạo mảng A ngẫu nhiên 
        taoMang(ref a1, dodai, 10, 80);
        // Xuất kết quả 
        xuatMang(a1);
    }
}