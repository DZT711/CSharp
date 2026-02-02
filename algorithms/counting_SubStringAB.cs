class counting_SubStringAB
{
    static void count(string str)
    {
        int countA = 0;
        int result = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == 'A')
            {
                countA++;
            }
            else if (str[i] == 'B')
            {
                result += countA;
            }
        }
        Console.WriteLine("Number of substrings 'AB': " + result);
    }
    static void BruteForce_count(string str)
    {
        int result = 0;
        int n = str.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (str[i] == 'A' && str[j] == 'B')
                {
                    result++;
                }
            }
        }
        Console.WriteLine("Number of substrings 'AB' (Brute Force): " + result);
    }
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        Console.Write("Choose a algorithm (1- Efficient, 2- Brute Force): ");
        int choice = Convert.ToInt32(Console.ReadLine());
        var startTime = DateTime.Now;
        if (choice == 1)
        {
            count(str);
        }
        else
        {
            BruteForce_count(str);
        }
        var endTime = DateTime.Now;
        Console.WriteLine("Processing time: " + (endTime - startTime).TotalMilliseconds + " ms");
        // Example Input/Output:
        // Enter a string: ABABAB
        // Number of substrings 'AB': 9
    }
}