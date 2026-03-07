
class quadraticEquation
{
    /// <summary> 
    /// Giải phương trình bậc 2: ax^2 + bx + c = 0 
    /// </summary> 
    /// <param name="a">hệ số a</param> 
    /// <param name="b">hệ số b</param> 
    /// <param name="c">hệ số c</param> 
    /// <param name="x1">Kết quả: nghiệm x1</param> 
    /// <param name="x2">Kết quả: nghiệm x2</param> 
    /// <returns>-1 (vô số nghiệm), 0 (vô nghiệm), 1 (1 nghiệm, x1), 2 (2 nghiệm x1, x2)</returns> 
    /// <example> 
    /// a = 1, b = 5, c = 6 --> return = 2, x1 = -3, x2 = -2 
    /// </example> 
    public static int giaiPhuongTrinhBac2(double a, double b, double c, ref double x1, ref double x2)
    {
        int co;// -1 (vô số nghiệm), 0 (vô nghiệm), 1 (1 nghiệm), 2 (2 nghiệm) 

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                    co = -1;
                else
                    co = 0;
            }
            else
            {
                co = 1;
                x1 = -b / a;
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
                co = -1;
            else if (delta == 0)
            {
                co = 1;
                x1 = -b / (2 * a);
            }
            else
            {
                co = 2;
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            }
        }
        return co;
    }

    public static void Main(string[] args)
    {
        // Khai báo biến 
        string[] tam;
        double hsa, hsb, hsc, n1 = 0, n2 = 0;
        int songhiem;

        // Nhập dữ liệu 
        Console.Write("Moi ban nhap he so a, b, c: ");
        tam = Console.ReadLine().Split(new char[] { ' ', '\t' }, System.StringSplitOptions.RemoveEmptyEntries);

        if (tam.Length != 3)
        {
            Console.WriteLine("Loi: Ban phai nhap dung 3 he so (a, b, c) cach nhau boi khoang trang hoac tab.");
            return;
        }

        hsa = double.Parse(tam[0]);
        hsb = double.Parse(tam[1]);
        hsc = double.Parse(tam[2]);

        // Xử lý 
        songhiem = giaiPhuongTrinhBac2(hsa, hsb, hsc, ref n1, ref n2);

        // Xuất dữ liệu 
        Console.Write("Phuong trinh bac 2 {0}x^2 + {1}x + {2} = 0 co: ", hsa, hsb, hsc);
        if (songhiem == -1)
            Console.WriteLine(" vo so nghiem.");
        else if (songhiem == 0)
            Console.WriteLine(" vo nghiem.");
        else if (songhiem == 1)
            Console.WriteLine(" 1 nghiem, x = {0: #.00}.", n1);
        else if (songhiem == 2)
            Console.WriteLine(" 2 nghiem, x1 = {0: #.00}, x2 = {1:#.00}.", n1, n2);
    }
}

