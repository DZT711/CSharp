namespace TransformAndConquer;

class IntersectionArraAndb
{
    static int[] BruteForce(int[] a, int[] b)
    {
        int[] C = new int[Math.Min(a.Length, b.Length)];
        int i = 0, j = 0, k = 0;
        while (i < a.Length && j < b.Length)
        {
            if (a[i] == b[j])
            {
                C[k++] = a[i];
                Console.WriteLine(a[i]);
                i++;
                j++;
            }
            else if (a[i] < b[j])
            {
                i++;
            }
            else
            {
                j++;
            }
        }
        return C;
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
    static int[] PreSortingAlg(int[] a, int[] b)
    {
        QuickSort(a);
        QuickSort(b);
        int[] C = new int[Math.Min(a.Length, b.Length)];
        int i = 0, j = 0, k = 0;
        while (i < a.Length && j < b.Length)
        {
            if (a[i] == b[j])
            {
                C[k++] = a[i];
                Console.WriteLine(a[i]);
                i++;
                j++;
            }
            else if (a[i] < b[j])
            {
                i++;
            }
            else
            {
                j++;
            }
        }
        return C;
    } 
    public static void Main(string[] args)
    {
        int[] a = [1, 2, 4, 5, 6];
        int[] b = [2, 3, 5, 7];
        BruteForce(a, b);
        PreSortingAlg(a, b);
    }
}