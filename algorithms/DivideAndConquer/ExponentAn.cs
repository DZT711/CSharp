class ExponentAn{
    public double Calculate(double a, double n)
    {
        if (n == 0)
        {
            return 1;
        }
        else if (n == 1)
        {
            return a;
        }
        double half = Calculate(a, (double)Math.Floor((double)n / 2));
        // Implementation for calculating a^n
        if (n % 2 == 0)
        {
            return half * half;
        }
        return half * half * a;
    }
    public void BruteForce(double a, double n)
    {
        double result = 1;
        for (double i = 0; i < n; i++)
        {
            result *= a;
        }
        Console.WriteLine("BF Result: " + result);
    }
    public static void Main(string[] args)
    {
        ExponentAn exp = new ExponentAn();
        double result = exp.Calculate(2, 100);
        Console.WriteLine("Divide and Conquer Algorithm Result: " + result);
        exp.BruteForce(2, 100);
    }
}