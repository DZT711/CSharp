class linearEquation
{
    public static void Main(string[] args)
    {
        // Khai báo biến
        double a, b;
        double x = 0;
        // Cờ trạng thái nghiệm
        int sn;// -1: Vô số nghiệm, 0: Vô nghiệm, 1: 1 nghiệm
               // Nhập dữ liệu
        Console.Write("Moi ban nhap he so a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Moi ban nhap he so b: ");
        b = double.Parse(Console.ReadLine());
        // Xử lý
        if (a == 0)
        {
            if (b == 0)// a == 0 và b == 0
            {
                sn = -1;
            }
            else// a == 0 và b != 0
            {
                sn = 0;
            }
        }
        else// a != 0
        {
            sn = 1;
            x = -b / a;
        }
        // Xuất kết quả
        Console.Write("Phuong trinh {0}x + {1} = 0 co: ", a, b);
        if (sn == -1)
        {
            Console.WriteLine(" vo so nghiem.");
        }
        else if (sn == 0)
        {
            Console.WriteLine(" vo nghiem.");
        }
        else// sn == 1
        {
            Console.WriteLine(" 1 nghiem, x = {0:#.00}.", x);
        }
    }
}