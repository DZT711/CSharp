using System;
using System.Collections.Generic;

public abstract class Shape
{
    // Khai báo là field để có thể gán giá trị
    protected string color;
    protected bool filled;

    public Shape()
    {
        this.color = "Red";
        this.filled = true;
    }

    public Shape(string color, bool filled)
    {
        this.color = color;
        this.filled = filled;
    }

    public string GetColor() => color;
    public void SetColor(string color) => this.color = color;
    public bool IsFilled() => filled;
    public void SetFilled(bool filled) => this.filled = filled;

    // Abstract method KHÔNG được có thân hàm { }
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"Shape[color={color}, filled={filled}]";
    }
}

class Circle : Shape
{
    protected double radius;

    public Circle() : base() { radius = 1.0; }
    public Circle(double radius) { this.radius = radius; }
    public Circle(double radius, string color, bool filled) : base(color, filled)
    {
        this.radius = radius;
    }

    public double GetRadius() => radius;
    public void SetRadius(double radius) => this.radius = radius;

    public override double GetArea() => Math.PI * radius * radius;
    public override double GetPerimeter() => 2 * Math.PI * radius;

    public override string ToString()
    {
        return $"Circle[{base.ToString()}, radius={radius}]";
    }
}

class Rectangle : Shape
{
    protected double width;
    protected double length;

    public Rectangle() : base() { width = 1.0; length = 1.0; }
    public Rectangle(double width, double length) { this.width = width; this.length = length; }
    public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
    {
        this.width = width;
        this.length = length;
    }

    // Dùng virtual để lớp Square có thể override (ghi đè)
    public virtual double GetWidth() => width;
    public virtual void SetWidth(double width) => this.width = width;
    public virtual double GetLength() => length;
    public virtual void SetLength(double length) => this.length = length;

    public override double GetArea() => width * length;
    public override double GetPerimeter() => 2 * (width + length);

    public override string ToString()
    {
        return $"Rectangle[{base.ToString()}, width={width}, length={length}]";
    }
}

class Square : Rectangle
{
    public Square() : base() { }
    public Square(double side) : base(side, side) { }
    public Square(double side, string color, bool filled) : base(side, side, color, filled) { }

    public double GetSide() => GetWidth();
    public void SetSide(double side)
    {
        base.SetWidth(side);
        base.SetLength(side);
    }

    public override void SetWidth(double side) => SetSide(side);
    public override void SetLength(double side) => SetSide(side);

    public override string ToString()
    {
        return $"Square[{base.ToString()}]";
    }
}

// --- HÀM MAIN THỰC THI ---
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        Shape[] shapes = new Shape[5]; // Mảng chứa 5 hình ngẫu nhiên
        string[] colors = { "Red", "Blue", "Green", "Yellow", "Pink" };

        for (int i = 0; i < shapes.Length; i++)
        {
            int type = rand.Next(0, 3); // Ngẫu nhiên loại hình
            string randomColor = colors[rand.Next(colors.Length)];
            bool randomFilled = rand.Next(2) == 0;

            if (type == 0)
                shapes[i] = new Circle(rand.Next(1, 10), randomColor, randomFilled);
            else if (type == 1)
                shapes[i] = new Rectangle(rand.Next(1, 10), rand.Next(1, 10), randomColor, randomFilled);
            else
                shapes[i] = new Square(rand.Next(1, 10), randomColor, randomFilled);
        }

        // TÍNH TỔNG CHU VI
        double totalPerimeter = 0;
        Console.WriteLine("Danh sach cac hinh duoc tao:");
        foreach (Shape s in shapes)
        {
            double p = s.GetPerimeter();
            totalPerimeter += p;
            Console.WriteLine($"- {s.ToString()} | Chu vi: {p:F2}");
        }

        Console.WriteLine("--------------------------------------");
        Console.WriteLine($"=> TONG CHU VI CUA MANG LA: {totalPerimeter:F2}");
    }
}