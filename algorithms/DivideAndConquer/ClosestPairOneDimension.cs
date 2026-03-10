class ClosestPairOneDimension
{
    // public static double FindClosestPairBF(double[] points, int n)
    // {
    //     double minDistance = double.MaxValue;
    //     for (int i = 0; i < n - 1; i++)
    //     {
    //         for (int j = i + 1; j < n; j++)
    //         {
    //             double distance = Math.Abs(points[i] - points[j]);
    //             if (distance < minDistance)
    //             {
    //                 minDistance = distance;
    //             }
    //         }
    //     }
    //     return minDistance;
    // }
    public static double FindClosestPairDAC(double[] points, int l, int r)
    {
        // 1. Base Case: Nếu chỉ có 2 hoặc 3 phần tử, tính trực tiếp
        int n = r - l + 1;
        if (n <= 3)
        {
            double minDist = double.MaxValue;
            for (int i = l; i < r; i++)
            {
                for (int k = i + 1; k <= r; k++)
                {
                    double d = Math.Abs(points[i] - points[k]);
                    if (d < minDist) minDist = d;
                }
            }
            return minDist;
        }

        // 2. Chia (Divide)
        int mid = l + (r - l) / 2;

        // 3. Trị (Conquer - Đệ quy)
        double distanceL = FindClosestPairDAC(points, l, mid);
        double distanceR = FindClosestPairDAC(points, mid + 1, r);

        // 4. Kết hợp (Combine)
        double dMinSide = Math.Min(distanceL, distanceR);

        // Khoảng cách giữa hai điểm sát ranh giới (Cross distance)
        double cross = Math.Abs(points[mid + 1] - points[mid]);

        return Math.Min(dMinSide, cross);
    }
    public static void Main(String[] args)
    {
        double[] points = { 1, 3, 5, 7, 9 };
        int n = points.Length;
        Array.Sort(points);
        double result = FindClosestPairDAC(points, 0, n - 1);
        Console.WriteLine("The closest pair distance is: " + result);
    }
}