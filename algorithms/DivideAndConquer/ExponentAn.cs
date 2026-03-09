class ExponentAn{
    public int Calculate(int a, int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else if (n == 1)
        {
            return a;
        }
        int half = Calculate(a, (int)Math.Floor((double)n / 2));
        // Implementation for calculating a^n
        if (n % 2 == 0){
            return half * half;
        }
        return half * half * a;
    }
    public static void Main(string[] args)
    {
        ExponentAn exp = new ExponentAn();
        int result = exp.Calculate(2, 3);
        Console.WriteLine("Result: " + result);
    }
}