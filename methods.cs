class methods
{
    static void Main()
    {
        Write();//call a method
        PrintTotal(10, 20);
        City();
        City("Ha Noi");
        City("TPHCM");
        Console.WriteLine(Multiple(10, 20));
    }

    static void Write()//method
    {
        Console.WriteLine("Writing....");
    }

    static void PrintTotal(int num1, int num2)
    {
        int total = num1 + num2;
        Console.WriteLine(total);
    }

    //method with default parameter
    static void City(string name = "Quang Ngai")
    {
        Console.WriteLine(name);
    }

    static int Multiple(int n1, int n2)
    {
        return n1 * n2;
    }
}