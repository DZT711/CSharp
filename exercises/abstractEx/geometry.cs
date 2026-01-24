

public abstract class Shape
{
    protected string Color() => "Red";
    protected bool Filled() => true;

    public Shape()
    {
        this.Color = "Red";
        this.Filled = true;
    }
    public Shape(string color, bool filled)
    {
        this.Color = color;
        this.Filled = filled;
    }
    public string GetColor()
    {
        return this.Color;
    }
    public void SetColor(string color)
    {
        this.Color = color;
    }
    public bool IsFilled()
    {
        return this.Filled;
    }
    public void SetFilled(bool filled)
    {
        this.Filled = filled;
    }
    public abstract double GetArea()
    {
        return 0;
    }
    public abstract double GetPerimeter()
    {
        return 0;
    }
    public override string ToString()
    {
        return "A Shape with color of " + this.Color + " and " + (this.Filled ? "filled" : "not filled");
    }

}
class Circle : Shape
{
    protected double radius => 1.0;
    public Circle()
    {
        this.radius = 1.0;
    }
    public Circle(double radius)
    {
        this.radius = radius;
    }

    public Circle(double radius, string color, bool filled) : base(color, filled)
    {
        this.radius = radius;
        this.Color = color;
        this.Filled = filled;
    }
    public double GetRadius()
    {
        return radius;
    }
    public void SetRadius(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }
    public override string ToString()
    {
        return "A Circle with radius=" + radius + " , color=" + this.Color + " and " + (this.Filled ? "filled" : "not filled");
    }
}

class Rectangle : Shape
{
    protected double width => 1.0;
    protected double length => 1.0;
    public Rectangle()
    {
        this.width = 1.0;
        this.length = 1.0;
    }
    public Rectangle(double width, double length)
    {
        this.width = width;
        this.length = length;
    }
    public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
    {
        this.width = width;
        this.length = length;
        this.Color = color;
        this.Filled = filled;
    }
    public double GetWidth()
    {
        return width;
    }
    public void SetWidth(double width)
    {
        this.width = width;
    }
    public double GetLength()
    {
        return length;
    }
    public void SetLength(double length)
    {
        this.length = length;
    }
    public override double GetArea()
    {
        return width * length;
    }
    public override double GetPerimeter()
    {
        return 2 * (width + length);
    }
    public override string ToString()
    {
        return "A Rectangle with width=" + width + " and length=" + length + " , color=" + this.Color + " and " + (this.Filled ? "filled" : "not filled");
    }
}
class Square : Rectangle
{
    public Square() : base()
    {
        this.width = 1.0;
        this.length = 1.0;
    }
    public Square(double side) : base(side, side)
    {
        this.width = side;
        this.length = side;
    }
    public Square(double side, string color, bool filled) : base(side, side, color, filled)
    {
        this.width = side;
        this.length = side;
        this.Color = color;
        this.Filled = filled;
    }

    public double GetSide()
    {
        return GetWidth();
    }
    public void SetSide(double side)
    {
        SetWidth(side);
        SetLength(side);
    }
    public override void SetWidth(double side)
    {
        base.SetWidth(side);
        base.SetLength(side);
    }
    public override void SetLength(double side)
    {
        base.SetLength(side);
        base.SetWidth(side);
    }
    public override string ToString()
    {
        return "A Square with side=" + GetSide() + " , color=" + this.Color + " and " + (this.Filled ? "filled" : "not filled");
    }
}
// class Main
// {
//     static void Main()
//     {
//         Circle c1 = new(5.0, "Blue", true);
//         Rectangle r1 = new(4.0, 6.0, "Green", false);
//         Square s1 = new(3.0, "Yellow", true);
//         Console.WriteLine(c1.ToString());
//         Console.WriteLine(r1.ToString());
//         Console.WriteLine(s1.ToString());
//     }
// }