using System;
namespace Ex3
{
    public class Student
    {
        public string Name { get; set; }
        public float GPA { get; set; }
        public Student(string name, float gpa)
        {
            Name = name;
            GPA = gpa;
        }
        public void Introduce()
        {
            Console.WriteLine($"Tôi là {Name} và {GPA}!");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student("Alice", 3.8f);
            student.Introduce();
        }
    }
}