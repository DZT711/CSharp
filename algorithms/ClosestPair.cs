class ClosestPair
{
    static int BF_FindNearestPoints(int[] points, int n, int[] res)
    {
        double minDist = double.MaxValue;
        int point1 = -1, point2 = -1;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                double dist = Math.Sqrt(Math.Pow(points[i] - points[j], 2));
                if (dist < minDist)
                {
                    minDist = dist;
                    point1 = i;
                    point2 = j;
                }
            }
        }

        // Console.WriteLine($"The closest points are: ({points[point1]}, {points[point2]}) with a distance of {minDist}");
        res[0] = point1;
        res[1] = point2;
        return (int)minDist;
    }
    static int Effective_FindNearestPoints(int[] points, int n, int[] res)
    {
        int[] sortedPoints = new int[n];
        Array.Copy(points, sortedPoints, points.Length);
        Array.Sort(sortedPoints);
        int min = int.MaxValue;
        for (int i = 0; i < n - 1; i++)
        {
            double dist = Math.Sqrt(Math.Pow(sortedPoints[i] - sortedPoints[i + 1], 2));
            if (dist < min)
            {
                min = (int)dist;
                res[0] = Array.IndexOf(points, sortedPoints[i]);
                res[1] = Array.IndexOf(points, sortedPoints[i + 1]);
            }
        }
        return (int)min;
    }
    static void Main(string[] args)
    {
        Console.Write("Input number of points:");
        int n = int.Parse(Console.ReadLine());
        int[] points = new int[n];
        Console.WriteLine("Input points (x):");
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            points[i] = int.Parse(input[0]);
        }

        int[] res = new int[2];
        int minDist = BF_FindNearestPoints(points, n, res);
        
        Console.Write("Choose method (1 - Brute Force, 2 - Effective): ");
        int method = int.Parse(Console.ReadLine());
        if (method == 1)
        {
            
            Console.WriteLine($"The closest points are: ({points[res[0]]}, {points[res[1]]}) with a distance of {minDist}");
        } else
        {
            minDist = Effective_FindNearestPoints(points, n, res);

            Console.WriteLine($"The closest points are: ({points[res[0]]}, {points[res[1]]}) with a distance of {minDist}");
        }

    }
}