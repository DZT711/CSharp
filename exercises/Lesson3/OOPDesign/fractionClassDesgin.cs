class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        this.numerator = numerator;
        this.denominator = denominator;
        Simplify();
        
    }

    private void Simplify()
    {
        int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
        numerator /= gcd;
        denominator /= gcd;
        if (denominator < 0)
        {
            numerator = -numerator;
            denominator = -denominator;
        }

    }

    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public override string ToString()
    {
        if (denominator == 1)
        {
            return $"{numerator}";
        }
        else if (numerator == 0)
        {
            return "0";
        }
        else
        {
            
            return $"{numerator}/{denominator}";
        }

    }
    
}
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Fraction fraction1 = new Fraction(3, 4);
            Fraction fraction2 = new Fraction(4, 2);
            Fraction fraction3 = new Fraction(0, 10);
            Fraction fraction4 = new Fraction(323, 1);
            // Fraction fraction2 = new Fraction(5, 0); // This will throw an exception
            Console.WriteLine(fraction1);
            Console.WriteLine(fraction2);
            Console.WriteLine(fraction3);
            Console.WriteLine(fraction4);
            // Console.WriteLine(fraction2);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}