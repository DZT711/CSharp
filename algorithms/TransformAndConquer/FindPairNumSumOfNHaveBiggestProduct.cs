class Program
{
    static void Main(string[] args)
    {
        int n = 0;
        Console.WriteLine("Enter a positive integer n:");
        while (true)        
        {
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {               
                break;
            }           
            else
            {     
                Console.WriteLine("Invalid input. Please enter a positive integer:");
            }
        }
        var result = FindPairNumSumOfNHaveBiggestProduct(n);
        Console.WriteLine($"The pair of numbers that sum up to {n} and have the biggest product are: {result.Item1} and {result.Item2}");
    }

    static Tuple<int, int> FindPairNumSumOfNHaveBiggestProduct(int n)
    {
        int maxProduct = 0;
        int num1 = 0, num2 = 0;
        if (n < 2)
        {
            throw new ArgumentException("n must be at least 2 to have a valid pair of numbers.");
        }
        for (int i = 1; i < n; i++)
        {
            int j = n - i;
            int product = i * j;

            if (product > maxProduct)
            {
                maxProduct = product;
                num1 = i;
                num2 = j;
            }
        }

        return Tuple.Create(num1, num2);
    }
}