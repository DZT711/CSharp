class Program
{
    static int FindClosestPair(int[] arr)
    {
        if (arr.Length < 2)
            throw new ArgumentException("Array must contain at least two elements.");

        Array.Sort(arr);
        int minDiff = int.MaxValue;

        for (int i = 1; i < arr.Length; i++)
        {
            int diff = arr[i] - arr[i - 1];
            if (diff < minDiff)
            {
                minDiff = diff;
            }
        }

        return minDiff;
    }
    static void QuickSort(int[] arr)
    {
        if (arr.Length <= 1)
            return;

        int pivot = arr[arr.Length / 2];
        int[] left = arr.Where(x => x < pivot).ToArray();
        int[] middle = arr.Where(x => x == pivot).ToArray();
        int[] right = arr.Where(x => x > pivot).ToArray();

        QuickSort(left);
        QuickSort(right);

        Array.Copy(left, 0, arr, 0, left.Length);
        Array.Copy(middle, 0, arr, left.Length, middle.Length);
        Array.Copy(right, 0, arr, left.Length + middle.Length, right.Length);
    }
    static int PreSortingAlg(int[] arr)
    {
        QuickSort(arr);
        int minDiff = int.MaxValue;
        for (int i = 1; i < arr.Length; i++)
        {
            int diff = arr[i] - arr[i - 1];
            if (diff < minDiff)
            {
                minDiff = diff;
            }
        }
        return minDiff;
    }
    static int BruteForceAlg(int[] arr)
    {
        int minDiff = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                int diff = Math.Abs(arr[i] - arr[j]);
                if (diff < minDiff)
                {
                    minDiff = diff;
                }
            }
        }
        return minDiff;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        try
        {
            // int closestPairDistance = FindClosestPair(arr);
            int closestPairDistance = PreSortingAlg(arr);
            Console.WriteLine($"The distance between the two closest numbers is: {closestPairDistance}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}