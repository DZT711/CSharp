class Animal
{
    public string name = "";
    //C# provides an option to override the base class method, by adding the virtual keyword to the method inside the base class,
    //  and by using the override keyword for each derived class methods:
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound.");
    }
}

class Dog : Animal//class Dog inherits/extends from Animal
{
    public Dog(string name)
    {
        this.name = name;
    }

    public void Bark()
    {
        Console.WriteLine($"{name} barks.");
    }

    public override void Sound()
    {
        Console.WriteLine($"{name} makes a barking sound.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog("Buddy");
        myDog.Bark(); // Buddy barks.
        myDog.Sound(); // Buddy makes a barking sound.

        Animal myAnimal = new Animal();
        myAnimal.Sound(); // Animal makes a sound.
        
        // Demonstrating polymorphism
        Animal anotherDog = new Dog("Max");
        anotherDog.Sound(); // Max makes a barking sound.
    }
}