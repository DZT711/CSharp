// Modifier     Description
// public       The code is accessible for all classes
// private      The code is only accessible within the same class
// protected    The code is accessible within the same class, or in a class that is inherited from that class. You will learn more about inheritance in a later chapter
// internal     The code is only accessible within its own assembly, but not from another assembly. You will learn more about this in a later chapter

class MainClass
{
    static void Main(string[] args)
    {
        // Accessing PublicElement from MainClass
        PublicElement publicElement = new PublicElement();
        Console.WriteLine("Accessing Public Field: " + publicElement._publicField);
        publicElement.PublicMethod();

        // Uncommenting the following lines will cause a compilation error
        // because PrivateElement is private and cannot be accessed here.
        // PrivateElement privateElement = new PrivateElement();
        // Console.WriteLine(privateElement._privateField);
        // privateElement.PrivateMethod();
    }
}

//private
class PrivateElement
{
    private int _privateField = 1;

    private void PrivateMethod()
    {
        Console.WriteLine("Private Method");
    }

    // static void Main(string[] args)
    // {
    //     Console.WriteLine("Private Element can only be accessed within the same class.");
    //     PrivateElement privateInstance = new PrivateElement();
    //     Console.WriteLine(privateInstance._privateField);
    //     privateInstance.PrivateMethod();

    // }
}
//public
class PublicElement
{
    public int _publicField = 1;

    public void PublicMethod()
    {
        Console.WriteLine("Public Method");
    }


}
