class Item
{
    int id;
    string name;
    double price;
    public Item(int id, string name, double price)
    {
        this.id = id;
        this.name = name;
        this.price = price;
    }

    public Item()
    {
        id = 0;
        name = "";
        price = 0.0;
    }
    static void Main(string[] args)
    {
        Item i1 = new Item(1, "Laptop", 1000.0);
        Item i2 = new Item();
        Console.WriteLine(i1.id + " " + i1.name + " " + i1.price);
        Console.WriteLine(i2.id + " " + i2.name + " " + i2.price);
    }
}