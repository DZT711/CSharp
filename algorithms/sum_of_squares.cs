using System;

class SumOfSquares
{
    // Original algorithm: O(n)
    public static long ComputeSumOfSquaresLoop(int n)
    {
        long sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += (long)i * i;
        }
        return sum;
    }

    // Improved algorithm: O(1)
    public static long ComputeSumOfSquaresFormula(int n)
    {
        //2L is used to ensure that the multiplication is done in long to prevent overflow for large n
        return (long)n * (n + 1) * (2L * n + 1) / 6;
    }
    public static long ComputeSumOfSquaresOptimized(int n)
    {
        long s =0;
        for (int i = 1; i <= n; i++)        {
            s += (long)i * i;
        }
        return s;

    }

    static void Main(string[] args)
    {
        Console.Write("Enter a nonnegative integer n: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
        {
            Console.WriteLine("Please enter a nonnegative integer.");
            return;
        }

        long resultLoop = ComputeSumOfSquaresLoop(n);
        long resultFormula = ComputeSumOfSquaresFormula(n);
        long resultOptimized = ComputeSumOfSquaresOptimized(n);

        Console.WriteLine($"Sum of squares from 1 to {n} (loop): {resultLoop}");
        Console.WriteLine($"Sum of squares from 1 to {n} (formula): {resultFormula}");
        Console.WriteLine($"Sum of squares from 1 to {n} (optimized): {resultOptimized}");
        Console.WriteLine("Formula version is O(1) time, while the loop version is O(n) time.");
    }
}
