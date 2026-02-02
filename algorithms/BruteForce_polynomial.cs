class Program
{
    static int Calculate(int[] coefficients, int x, int n)
    {
        int res = 0;
        for (int i = 0; i < n; i++)
        {
            int Power = 1;
            for (int j = 0; j < i; j++)
            {
                Power *= x;
            }
            int term = coefficients[i] * Power;
            res += term;
        }
        return res;
    }

    static void Main(string[] args)
    {
        int n;
        Console.Write("Enter the degree of the polynomial: ");
        n = Convert.ToInt32(Console.ReadLine());
        int[] coefficients = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter coefficient a{i}: ");
            coefficients[i] = Convert.ToInt32(Console.ReadLine());
        }
        int x;
        Console.Write("Enter the value of x: ");
        x = Convert.ToInt32(Console.ReadLine());
        int result = Calculate(coefficients, x, n);
        Console.WriteLine($"The value of the polynomial at x = {x} is: {result}");
        // Example Input/Output:
        // Enter the degree of the polynomial: 3
        // Enter coefficient a0: 2
        // Enter coefficient a1: 3
        // Enter coefficient a2: 4
        // Enter the value of x: 5
        // The value of the polynomial at x = 5 is: 2*5^0 + 3*5^1 + 4*5^2 = 2 + 15 + 100 = 117
    }
}