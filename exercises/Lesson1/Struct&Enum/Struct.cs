class Struct
{
    public struct CuonSach
    {
        public string maSach;
        public string tenSach;
        public int giaBan;
        public int soLuong;
    };
    public struct DanhMuc
    {
        public string tenDanhMuc;
        public CuonSach[] dsCuonSach;
    };

    public static void nhapDanhMuc(ref DanhMuc dm)
    {
        int soSach;
        Console.Write("Nhap ten danh muc: ");
        dm.tenDanhMuc = Console.ReadLine();
        Console.Write("Nhap so luong sach: ");
        soSach = int.Parse(Console.ReadLine());
        dm.dsCuonSach = new CuonSach[soSach];

        for (int i = 0; i < soSach; i++)
        {
            Console.WriteLine("- Sach thu {0}:", i + 1);
            Console.Write("  Ma sach: ");
            dm.dsCuonSach[i].maSach = Console.ReadLine();
            Console.Write("  Ten sach: ");
            dm.dsCuonSach[i].tenSach = Console.ReadLine();
            Console.Write("  Gia ban: ");
            dm.dsCuonSach[i].giaBan = int.Parse(Console.ReadLine());
            Console.Write("  So luong: ");
            dm.dsCuonSach[i].soLuong = int.Parse(Console.ReadLine());
        }
    }

    public static void xuatDanhMuc(DanhMuc dm)
    {
        Console.WriteLine("\n=== Danh muc: {0} ===", dm.tenDanhMuc);
        for (int i = 0; i < dm.dsCuonSach.Length; i++)
        {
            Console.WriteLine("Sach {0}: Ma={1}, Ten={2}, Gia={3}, SoLuong={4}",
                i + 1, dm.dsCuonSach[i].maSach, dm.dsCuonSach[i].tenSach,
                dm.dsCuonSach[i].giaBan, dm.dsCuonSach[i].soLuong);
        }
        Console.WriteLine();
    }

    public static void kiemTraTimSach()
    {
        DanhMuc dm = new DanhMuc
        {
            tenDanhMuc = "Lap trinh",
            dsCuonSach = new CuonSach[]{
            new CuonSach { maSach = "NMLT", tenSach = "Nhap mon lap trinh", giaBan= 75000,soLuong = 10 },
            new CuonSach { maSach = "KTLT", tenSach = "Ky thuat lap trinh", giaBan= 85000,soLuong = 15 }
        }
        };
        xuatDanhMuc(dm);

        CuonSach sach = new CuonSach();
        bool kq;

        kq = timSach(dm, "NMLT", ref sach);
        Console.WriteLine("Tim thay: {0} - Dap an: true", kq);
        Console.WriteLine("Thong tin: maSach={0}, tenSach={1}, giaBan={2}, soLuong={3}",
                sach.maSach, sach.tenSach, sach.giaBan, sach.soLuong);
        Console.WriteLine("Dap an   : maSach=NMLT, tenSach=Nhap mon lap trinh, giaBan=75000, soLuong = 10");
    }

    public static bool timSach(DanhMuc dm, string masach, ref CuonSach sach)
    {
        bool timThay;

        timThay = false;
        for (int i = 0; i <= dm.dsCuonSach.Length - 1 && timThay == false; i++)
        {
            if (dm.dsCuonSach[i].maSach == masach)
            {
                timThay = true;
                sach = dm.dsCuonSach[i];
            }
        }
        return timThay;
    }

    public static void Main(string[] args)
    {
        kiemTraTimSach();
    }
}