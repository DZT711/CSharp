class circleArea
{
    public class DienTichHinhTron
    {
        public static void Main(string[] args)
        {
            // Khai báo biến
            double d, r, s;
            // Nhập dữ liệu
            Console.Write("Moi ban nhap chu vi hinh tron: ");
            d = double.Parse(Console.ReadLine());
            // Xử lý
            r = d / (2 * Math.PI);
            s = r * r * Math.PI;
            // Xuất kết quả
            Console.WriteLine("Hinh tron co chu vi {0} co dien tich {1: #.00}.", d, s);
        }
    }

}