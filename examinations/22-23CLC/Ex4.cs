namespace Examinations._22_23CLC
{
    public class Ex4
    {
        class Item(int ID, int ItemID, double Sales)
        {
            public int ID { get; set; } = ID;
            public int ItemID { get; set; } = ItemID;
            public double Sales { get; set; } = Sales;

            public static void Report(Item[] a)
            {
                var totals = new Dictionary<int, double>();
                foreach (var item in a)
                {
                    if (!totals.ContainsKey(item.ID))
                    {
                        totals[item.ID] = 0;
                    }
                    totals[item.ID] += item.Sales;
                }

                Console.WriteLine("ID\tTotal Sales");
                foreach (var kvp in totals)
                {
                    Console.WriteLine($"{kvp.Key}\t{kvp.Value}");
                }
            }
        }
        public static void Main()
        {
            var items = new Item[]
            {
                new(100, 1, 100),
                new(200, 2, 200),
                new(100, 3, 300),
                new(100, 4, 400),
                new(300, 5, 150),
                new(200, 6, 250),
            };

            Item.Report(items);
        }

    }
}