class FindSumsInArr
{
    static void BFS(int[] a, int sum)
    {
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[i] + a[j] == sum)
                {
                    Console.WriteLine($"({a[i]}, {a[j]})");
                }
            }
        }
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
    static void PreSortingAlg(int[] arr, int sum)
    {
        QuickSort(arr);
        int left = 0, right = arr.Length - 1;
        while (left < right)
        {
            int currentSum = arr[left] + arr[right];
            if (currentSum == sum)
            {
                Console.WriteLine($"({arr[left]}, {arr[right]})");
                left++;
                right--;
            }
            else if (currentSum < sum)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
    }
    static void BinarySearchAlg(int[] arr, int sum)
    {
        QuickSort(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            int target = sum - arr[i];
            int left = i + 1, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                {
                    Console.WriteLine($"({arr[i]}, {arr[mid]})");
                    break;
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }
    }
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int sum = 5;
        BFS(arr, sum);
        BinarySearchAlg(arr, sum);
        PreSortingAlg(arr, sum);
    }
}
