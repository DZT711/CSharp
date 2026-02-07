using System;

namespace SortingApp
{
    // 1. Lớp Contact - Thực thi interface IComparable để có thể so sánh
    class Contact : IComparable
    {
        private string firstName, lastName, phone;

        public Contact(string first, string last, string telephone)
        {
            firstName = first;
            lastName = last;
            phone = telephone;
        }

        // Ghi đè phương thức ToString (tương tự java toString)
        public override string ToString()
        {
            return lastName + ", " + firstName + "\t" + phone;
        }

        // C# thường sử dụng Properties thay vì Getter/Setter thủ công
        public string GetFirstName() => firstName;
        public string GetLastName() => lastName;

        // Thực thi phương thức CompareTo của interface IComparable
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Contact other = obj as Contact;
            if (other == null)
                throw new ArgumentException("Đối tượng không phải là Contact");

            int result;
            string otherFirst = other.GetFirstName();
            string otherLast = other.GetLastName();

            // So sánh họ trước, nếu họ giống nhau thì mới so sánh tên
            if (this.lastName.Equals(otherLast))
            {
                result = this.firstName.CompareTo(otherFirst);
            }
            else
            {
                result = this.lastName.CompareTo(otherLast);
            }
            return result;
        }

        // Ghi đè Equals (tương tự Java)
        public override bool Equals(object obj)
        {
            if (obj is Contact other)
            {
                return (lastName.Equals(other.GetLastName()) &&
                        firstName.Equals(other.GetFirstName()));
            }
            return false;
        }

        public override int GetHashCode() => (lastName + firstName).GetHashCode();
    }

    class Book : IComparable
    {
        private string title;
        private string author;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public override string ToString()
        {
            return title + " by " + author;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Book other = obj as Book;
            if (other == null)
                throw new ArgumentException("Đối tượng không phải là Book");

            return this.title.CompareTo(other.title);
        }
    }
    class Car : IComparable
    {
        private string make;
        private string model;
        private int year;

        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public override string ToString()
        {
            return year + " " + make + " " + model;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Car other = obj as Car;
            if (other == null)
                throw new ArgumentException("Đối tượng không phải là Car");

            return this.year.CompareTo(other.year);
        }
    }
    class Student : IComparable
    {
        private string name;
        private double gpa;

        public Student(string name, double gpa)
        {
            this.name = name;
            this.gpa = gpa;
        }

        public override string ToString()
        {
            return name + " with GPA: " + gpa;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Student other = obj as Student;
            if (other == null)
                throw new ArgumentException("Đối tượng không phải là Student");

            return this.gpa.CompareTo(other.gpa);
        }
    }
    // 2. Lớp Sorting - Chứa các thuật toán sắp xếp
    class Sorting
    {
        // Sắp xếp chọn (Selection Sort)
        public static void SelectionSort(IComparable[] list)
        {
            int min;
            IComparable temp;

            for (int index = 0; index < list.Length - 1; index++)
            {
                min = index;
                for (int scan = index + 1; scan < list.Length; scan++)
                {
                    if (list[scan].CompareTo(list[min]) < 0)
                    {
                        min = scan;
                    }
                }
                // Tráo đổi vị trí
                temp = list[min];
                list[min] = list[index];
                list[index] = temp;
            }
        }

        // Sắp xếp chèn (Insertion Sort)
        public static void InsertionSort(IComparable[] list)
        {
            for (int index = 1; index < list.Length; index++)
            {
                IComparable key = list[index];
                int position = index;

                while (position > 0 && key.CompareTo(list[position - 1]) < 0)
                {
                    list[position] = list[position - 1];
                    position--;
                }
                list[position] = key;
            }
        }
    }

    // 3. Lớp Program (PhoneList) - Chứa hàm Main để chạy
    class Program
    {
        static void Main(string[] args)
        {
            Contact[] friends = new Contact[8];

            friends[0] = new Contact("John", "Smith", "610-555-7384");
            friends[1] = new Contact("Sarah", "Barnes", "215-555-3827");
            friends[2] = new Contact("Mark", "Riley", "733-555-2969");
            friends[3] = new Contact("Laura", "Getz", "663-555-3984");
            friends[4] = new Contact("Larry", "Smith", "464-555-3489");
            friends[5] = new Contact("Frank", "Phelps", "322-555-2284");
            friends[6] = new Contact("Mario", "Guzman", "804-555-9066");
            friends[7] = new Contact("Marsha", "Grant", "243-555-2837");

            // Thực hiện sắp xếp
            Sorting.SelectionSort(friends);

            Console.WriteLine("--- Danh sách sau khi sắp xếp (C#) ---\n");
            Console.WriteLine("Lớp Contact \n\nHọ, Tên\tSố điện thoại");
            foreach (var friend in friends)
            {
                Console.WriteLine(friend);
            }

            Book[] books = new Book[4]
            {
                new Book("The Great Gatsby", "F. Scott Fitzgerald"),
                new Book("1984", "George Orwell"),
                new Book("To Kill a Mockingbird", "Harper Lee"),
                new Book("Pride and Prejudice", "Jane Austen")
            };
            Sorting.InsertionSort(books);
            Console.WriteLine("\nLớp Book \n");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            Car[] cars = new Car[4]
            {
                new Car("Toyota", "Camry", 2020),
                new Car("Honda", "Civic", 2018),
                new Car("Ford", "Mustang", 2021),
                new Car("Chevrolet", "Malibu", 2019)
            };
            Sorting.InsertionSort(cars);
            Console.WriteLine("\nLớp Car \n");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            Student[] students = new Student[4]
            {
                new Student("Alice", 3.5),
                new Student("Bob", 3.8),
                new Student("Charlie", 3.2),
                new Student("Diana", 3.9)
            };
            Sorting.InsertionSort(students);
            Console.WriteLine("\nLớp Student \n");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            // Giữ màn hình console không tắt ngay
            // Console.WriteLine("\nNhan phim bat ky de thoat...");
            // Console.ReadKey();
        }
    }
}