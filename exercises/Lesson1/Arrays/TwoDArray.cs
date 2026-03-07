class TwoDArray
{
    public static void nhapMang(ref int[,] a)
    {
        int nd, nc, id, ic;
        // Nhập số dòng, cột 
        Console.Write("Moi ban nhap so dong: ");
        nd = int.Parse(Console.ReadLine());
        Console.Write("Moi ban nhap so cot: ");
        nc = int.Parse(Console.ReadLine());
        // Tạo mảng hai chiều 
        a = new int[nd, nc];
        // Nhập từng phần tử 
        for (id = 0; id <= a.GetLength(0) - 1; id++)
        {
            for (ic = 0; ic <= a.GetLength(1) - 1; ic++)
            {
                // Nhập a[id, ic] 
                Console.Write("+ Nhap phan tu [{0}, {1}] = ", id, ic);
                a[id, ic] = int.Parse(Console.ReadLine());
            }
        }
    }

    public static void taoMang(ref int[,] a, int nd, int nc, int vmin, int vmax)
    {
        Random rand = new Random(); // tạo đối tượng tạo số ngẫu nhiên 
                                    // Tạo mảng hai chiều 
        a = new int[nd, nc];
        // Nhập từng phần tử 
        for (int id = 0; id <= a.GetLength(0) - 1; id++)
        {
            for (int ic = 0; ic <= a.GetLength(1) - 1; ic++)
            {
                a[id, ic] = rand.Next(vmin, vmax);// Nhập a[id, ic] ngẫu nhiên 
            }
        }
    }

    public static void xuatMang(int[,] a)
    {
        // Xuất số phần tử 
        Console.WriteLine("Mang co {0} dong x {1} cot: ", a.GetLength(0), a.GetLength(1));
        // Xuất từng phần tử 
        for (int id = 0; id <= a.GetLength(0) - 1; id++)
        {
            for (int ic = 0; ic <= a.GetLength(1) - 1; ic++)
            {
                // Xuất a[id, ic] 
                Console.Write("{0, 5}", a[id, ic]);
            }
            Console.WriteLine();// Xuống dòng 
        }
    }

    public static void Main(string[] args)
    {
        // Khai báo mảng 2 chiều 
        int[,] a1 = null, b1 = null;

        Console.WriteLine("* Mang A: ");
        nhapMang(ref a1);// Nhập mảng 
        xuatMang(a1); // Xuất mảng 
        Console.WriteLine("* Mang B: ");
        taoMang(ref b1, 5, 6, 5, 100);// Nhập mảng 
        xuatMang(b1); // Xuất mảng 
    }
}