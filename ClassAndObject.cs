using System;
class Dog
{
    string name = "dog";

    static void Main()
    {
        Dog animal = new Dog();

        Console.WriteLine(animal.name);
    }
}

//sai chung container thi moi goi duoc lop cua file khac
namespace animalClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat animal = new Cat();
            Console.WriteLine(animal.numberOfFoot);
            animal.Sound();

            Chicken animal2 = new Chicken();
            Console.WriteLine(animal2.numberOfFoot);
        }
    }
}