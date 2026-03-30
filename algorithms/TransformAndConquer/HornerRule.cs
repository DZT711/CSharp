class HornerRule
{
    static int Horner(int[] a, int x)
    {
        int result = 0;
        for (int i = a.Length - 1; i >= 0; i--)
        {
            result = result * x + a[i];
        }
        return result;
    }
    static int Power(int x, int n)
    {
        if (n == 0)
            return 1;
        int half = Power(x, n / 2);
        if (n % 2 == 0)
            return half * half;
        else
            return half * half * x;
    }
    static int PolynomialEvaluation(int[] a, int x)
    {
        int result = 0;
        for (int i = 0; i < a.Length; i++)
        {
            result += a[i] * Power(x, i);
        }
        return result;
    }
    public static void Main(string[] args)
    {
        int[] a = { 2, -6, 2, -1 };
        int x = 3;
        Console.WriteLine(Horner(a, x));
        Console.WriteLine(PolynomialEvaluation(a, x));
    }
}