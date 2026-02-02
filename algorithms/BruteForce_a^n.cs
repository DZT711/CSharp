class Program {
    static int Power(int baseNum, int exponent)
    {
        int result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNum;
        }
        return result;
    }
    static void Main(string[] args)
    {
        int baseNum ;
        int exponent;
        Console.Write("Enter base number: ");
        baseNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter exponent: ");
        exponent = Convert.ToInt32(Console.ReadLine());
        int result = Power(baseNum, exponent);
        Console.WriteLine($"{baseNum}^{exponent} = {result}");
    }
}