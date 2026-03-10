class RearrageArray
{
    public static void Rearrange(int[] A, int n)
    {
        int left = 0;
        int right = n - 1;
        while (left < right)
        {
            if (A[left] < 0)
            {
                left += 1;
            }
            else if (A[right] >= 0)
            {
                right -= 1;
            }
            else
            {
                // Swap elements at left and right
                int temp = A[left];
                A[left] = A[right];
                A[right] = temp;
                left += 1;
                right -= 1;
            }
        }
        if (left < right)
        {
            int temp =A[left];
            A[left] = A[right];
            A[right] = temp;
            
            left += 1;
            right -= 1;
        }
    }
    public static void Main(string[] args)
    {
        int[] A = {-2, -18, 7, -99, 656, 89};
        Rearrange( A,  A.Length);
        Console.WriteLine(string.Join(", ", A));
    }
}