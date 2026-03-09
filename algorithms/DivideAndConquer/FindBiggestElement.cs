class FindBiggestElement
{
    public static int FindBiggest(int[] arr, int low, int high)
    {
        if (low == high)
            return arr[low];
        int mid = (low + high) / 2;
        int leftBiggest = FindBiggest(arr, low, mid);
        // Console.WriteLine("Left biggest: " + leftBiggest);
        int rightBiggest = FindBiggest(arr, mid + 1, high);
        // Console.WriteLine("Right biggest: " + rightBiggest);
        return Math.Max(leftBiggest, rightBiggest);
    }
    public void BruteForce(int[] arr)
    {
        int biggest = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > biggest)
                biggest = arr[i];
        }
        Console.WriteLine("The biggest element is: " + biggest);
    }
    public static void Main(string[] args)
    {
        int[] arr = { 3, 5, 2, 8, 1 };
        int biggest = FindBiggest(arr, 0, arr.Length - 1);
        Console.WriteLine("The biggest element is: " + biggest);
    }
}