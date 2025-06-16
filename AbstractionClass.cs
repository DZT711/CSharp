abstract class Animal
{
    public abstract void Speak();
    public void Sleep()
    {
        Console.WriteLine("Sleeping...");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Bark");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myDog = new Dog();
        myDog.Speak(); // Bark
        myDog.Sleep(); // Sleeping...
    }
}