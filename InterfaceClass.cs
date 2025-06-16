public interface IMyInterface
{
    void MyMethod();
    int MyProperty { get; set; }
}
public class MyClass : IMyInterface
{
    public void MyMethod()
    {
        Console.WriteLine("MyMethod implementation in MyClass.");
    }

    public int MyProperty { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        IMyInterface myObject = new MyClass();
        myObject.MyMethod(); // Output: MyMethod implementation in MyClass.
        myObject.MyProperty = 42;
        Console.WriteLine($"MyProperty value: {myObject.MyProperty}"); // Output: MyProperty value: 42

        MultipleInterfaceClass mySecondObject = new MultipleInterfaceClass();
        mySecondObject.MyMethod(); 
        mySecondObject.MyProperty = 84;
        Console.WriteLine($"MyProperty value: {mySecondObject.MyProperty}"); // Output: MyProperty value: 84
        mySecondObject.MySecondMethod(); // Output: MySecondMethod implementation in MultipleInterfaceClass.
        mySecondObject.MySecondProperty = 100;
        Console.WriteLine($"MySecondProperty value: {mySecondObject.MySecondProperty}"); // Output: MySecondProperty value: 100

    }
}

public interface IMySecondInterface
{
    void MySecondMethod();
    int MySecondProperty { get; set; }
}
public class MultipleInterfaceClass : IMyInterface, IMySecondInterface
{
    public void MyMethod()
    {
        Console.WriteLine("MyMethod implementation in MultipleInterfaceClass.");
    }

    public int MyProperty { get; set; }

    public void MySecondMethod()
    {
        Console.WriteLine("MySecondMethod implementation in MultipleInterfaceClass.");
    }

    public int MySecondProperty { get; set; }
}