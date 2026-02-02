class linear_polynominal
{
    static int Calculate(int[] a, int n, int x)
    {
        int res = a[0];
        for (int i = 1; i < n; i++)
        {

            res += (int)Math.Pow(x, i) * a[i];
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
        int result = Calculate(coefficients, n, x);
        Console.WriteLine($"The value of the polynomial at x = {x} is: {result}");
        // Example Input/Output:
        // Enter the degree of the polynomial: 3
        // Enter coefficient a0: 2
        // Enter coefficient a1: 3
        // Enter coefficient a2: 4
        // Enter the value of x: 5
        // The value of the polynomial at x = 5 is: 117
    }
}