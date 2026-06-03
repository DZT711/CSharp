class Program
{
    static void Main(string[] args)
    {
        int n = 5, k = 2;
        Console.WriteLine(BinomialCoefficient(n, k));
    }

    static int BinomialCoefficient(int n, int k)//C(n, k) = C(n-1, k-1) + C(n-1, k)
    {
        if (k == 0 || k == n)
            return 1;

        return BinomialCoefficient(n - 1, k - 1) + BinomialCoefficient(n - 1, k);
    }
}