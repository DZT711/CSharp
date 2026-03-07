
public class IO_TwoDimensionArr
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

    // tạo mảng a mà mỗi phần tử là mảng 2 chiều có số cột nc[i], số dòng nd[i] 
    public static void taoMang2C(ref int[][,] a, int[] nd, int[] nc, int vmin, int vmax)
    {
        Random rand = new Random();
        // tạo mảng mà mỗi phần tử là mảng 2 chiều 
        a = new int[nd.Length][,];
        // duyệt từng phần tử trong a 
        for (int i = 0; i <= a.Length - 1; i++)
        {
            // cấp phát cho từng a[i] 
            a[i] = new int[nd[i], nc[i]];
            // Duyệt từng dòng,cột của a[i] 
            for (int k = 0; k <= a[i].GetLength(0) - 1; k++)
            {
                for (int t = 0; t <= a[i].GetLength(1) - 1; t++)
                {
                    a[i][k, t] = rand.Next(vmin, vmax);
                }
            }
        }
    }

    public static void xuatMang(int[][,] a)
    {
        Console.WriteLine("Cac gia tri trong mang: ");
        // Xét từng dãy A[0], A[1], ..., A[n-1] 
        for (int i = 0; i <= a.Length - 1; i++)
        {
            Console.WriteLine("A[{0}]: ", i);
            // In ma trận a[i] 
            for (int k = 0; k <= a[i].GetLength(0) - 1; k++)
            {
                for (int t = 0; t <= a[i].GetLength(1) - 1; t++)
                {
                    Console.Write("{0, 5}", a[i][k, t]);
                }
                Console.WriteLine();
            }
        }
    }

    public static void Main(string[] args)
    {
        // Khai báo mảng 
        int[][,] a1 = null;
        int n;
        int[] socot = null, sodong = null;


        // Nhập số phần tử cho mảng A 
        Console.Write("Moi ban nhap so phan tu cho mang: ");
        n = int.Parse(Console.ReadLine());
        // Tạo số lượng phần tử cho cột, dòng ngẫu nhiên cho từng A[i] 
        taoDay(ref sodong, n, 3, 10);
        taoDay(ref socot, n, 3, 10);
        // Tạo mảng A ngẫu nhiên 
        taoMang2C(ref a1, sodong, socot, 10, 80);
        // Xuất kết quả 
        xuatMang(a1);
    }
}