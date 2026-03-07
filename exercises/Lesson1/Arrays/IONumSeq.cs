class IONumSeq
{
    public static void nhapDaySo(ref int[] day)
    {
        int i, n;

        // Nhập số lượngphần tử 
        Console.Write("Moi ban nhap so luong phan tu: ");
        n = int.Parse(Console.ReadLine());
        // Tạo mảng các phần tử 
        day = new int[n];
        // Nhập giá trị cho từng phần tử 
        for (i = 0; i <= day.Length - 1; i++)
        {
            Console.Write("Phan tu {0}: ", i);
            day[i] = int.Parse(Console.ReadLine());
        }
    }

    public static int[] sinhNgauNhienDaySo(int n, int vmin, int vmax)
    {
        int i;
        int[] day = null;
        // Tạo mảng các phần tử 
        day = new int[n];
        // Sinh ngẫu nhiên giá trị cho từng phần tử 
        Random rand = new Random();// Đối tượng sinh số ngẫu nhiên 
        for (i = 0; i <= day.Length - 1; i++)
        {
            day[i] = rand.Next(vmin, vmax);
        }
        return day;
    }

    public static void inMangTraiSangPhai(int[] day)
    {
        // In số phần tử 
        Console.Write("Day so co {0} phan tu:", day.Length);
        // Duyệt dãy từ đầu về cuối 
        for (int i = 0; i <= day.Length - 1; i++)
        {
            Console.Write(" {0}", day[i]);
        }
        Console.WriteLine();// Xuống dòng 
    }

    public static void inMangPhaiSangTrai(int[] day)
    {
        // In số phần tử 
        Console.Write("Day so co {0} phan tu:", day.Length);
        // Duyệt dãy từ cuối về đầu 
        for (int i = day.Length - 1; i >= 0; i--)
        {
            Console.Write(" {0}", day[i]);
        }
        Console.WriteLine();// Xuống dòng 
    }

    public static void Main(string[] args)
    {
        // Khai báo mảng 1 chiều 
        int[] a = null, b = null;
        int n;

        // Dãy số A 
        Console.WriteLine("* Day so A: ");
        nhapDaySo(ref a);
        inMangTraiSangPhai(a);
        inMangPhaiSangTrai(a);
        // Dãy số B 
        Console.WriteLine("* Day so B: ");
        Console.Write("Moi ban nhap so luong phan tu: ");
        n = int.Parse(Console.ReadLine());
        b = sinhNgauNhienDaySo(n, 300, 500);
        inMangTraiSangPhai(b);
        inMangPhaiSangTrai(b);
    }
}