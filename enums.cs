//By default, the first item of an enum has the value 0. The second has the value 1, and so on.

enum AnimalType
{
    Dog,
    Cat,
    Bird=7
}
class Program
{
    static void Main(string[] args)
    {
        AnimalType animal = AnimalType.Dog;
        Console.WriteLine($"Selected animal type: {animal}"); // Output: Selected animal type: Dog
        Console.WriteLine($"Animal type value: {(int)animal}"); // Output: Animal type value: 0
        AnimalType b=AnimalType.Bird;
        Console.WriteLine($"Selected animal type: {b}"); // Output: Selected animal type: Bird
        Console.WriteLine($"Animal type value: {(int)b}"); // Output: Animal type value: 7
    }
}
