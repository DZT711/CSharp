    class Searching
    {
        public static int BinarySearch(IComparable[] list, IComparable key)
        {
            int low = 0;
            int high = list.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int result = list[mid].CompareTo(key);

                if (result == 0)
                {
                    return mid; // Tìm thấy
                }
                else if (result < 0)
                {
                    low = mid + 1; // Tìm bên phải
                }
                else
                {
                    high = mid - 1; // Tìm bên trái
                }
            }
            return -1; // Không tìm thấy
        }
        public static int LinearSearch(IComparable[] list, IComparable key)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].CompareTo(key) == 0)
                {
                    return i; // Tìm thấy
                }
            }
            return -1; // Không tìm thấy
        }
    }