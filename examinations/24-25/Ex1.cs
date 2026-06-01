namespace Examinations._24_25
{
    public class Base
    {
        public int value=10;
        public void display()
        {
            Console.WriteLine("value: " + value);
        }
    }
    public class Derived : Base
    {
        public new void display()
        {
            value += 20;
            Console.WriteLine("value: " + value);
        }
    }
    internal class Program
    {
        static void Main()
        {
            Base b = new Derived();
            b.display();//method called depends on the reference type (Base), not the object type (Derived) b.display() calls Base.display() (not Derived.display())
            // Base.display() prints "value: " + value
            // value is still 10 (unchanged)
        }
    }
}