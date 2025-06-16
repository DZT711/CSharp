class Example
{
    public int _value = 7;
    public int Value
    {
        get { return _value; } // Getter: returns the value of _value
        set { _value = value; } // Setter: assigns a new value to _value
    }
}
class Program
{
    static void Main(string[] args)
    {
        Example example = new Example();

        // Accessing the property using the getter
        Console.WriteLine("Initial Value: " + example.Value);

        // Setting a new value using the setter
        example.Value = 10;

        // Accessing the updated value using the getter
        Console.WriteLine("Updated Value: " + example.Value);

        ExampleShort exampleShort = new ExampleShort();

        // Accessing the property using the getter
        Console.WriteLine("Short Example Value: " + exampleShort.Value);
        // Setting a new value using the setter
        exampleShort.Value = 20;
        // Accessing the updated value using the getter
        Console.WriteLine("Updated Short Example Value: " + exampleShort.Value);
    }
}

//short hand method
class ExampleShort
{
    public int Value { get; set; } = 7; // Auto-implemented property with a default value
}