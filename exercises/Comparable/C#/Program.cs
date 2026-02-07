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

        // Lớp Book
        public override string ToString()
        {
            return title + "\t" + author;
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

        // Lớp Car
        public override string ToString()
        {
            return year + "\t" + make + " " + model;
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

        // Lớp Student
        public override string ToString()
        {
            return name + "\t GPA:" + gpa;
        }
        public string GetName() => name;
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

    class Searching
    {
        // Tìm kiếm nhị phân (Chỉ dùng khi nhập ĐẦY ĐỦ các thuộc tính quan trọng để so sánh)
        public static int BinarySearch(IComparable[] list, IComparable key)
        {
            int low = 0, high = list.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int result = list[mid].CompareTo(key);
                if (result == 0) return mid;
                if (result < 0) low = mid + 1;
                else high = mid - 1;
            }
            return -1;
        }

        // Tìm kiếm linh hoạt (Cho phép nhập 1 phần hoặc 1 thuộc tính)
        // Func<T, bool> giúp chúng ta truyền điều kiện tìm kiếm vào
        public static int LinearSearchGeneric<T>(T[] list, Func<T, bool> match)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (match(list[i])) return i;
            }
            return -1;
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

            Console.WriteLine("--- List after sorting (C#) ---\n");
            Console.WriteLine("Class Contact \n");
            foreach (var friend in friends)
            {
                Console.WriteLine(friend);
            }

            Book[] books = new Book[3]
            {
                new Book("The Great Gatsby", "F. Scott Fitzgerald"),
                // new Book("1984", "George Orwell"),
                new Book("To Kill a Mockingbird", "Harper Lee"),
                new Book("Pride and Prejudice", "Jane Austen")
            };
            Sorting.InsertionSort(books);
            Console.WriteLine("Class Book \n");
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
            Console.WriteLine("Class Car \n");
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
            Console.WriteLine("Class Student \n");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            // Giữ màn hình console không tắt ngay
            // Console.WriteLine("\nNhan phim bat ky de thoat...");
            // Console.ReadKey();
            Console.WriteLine("Choose an object to search:");
            Console.WriteLine("1. Contact");
            Console.WriteLine("2. Book");
            Console.WriteLine("3. Car");
            Console.WriteLine("4. Student");
            string choice = Console.ReadLine();
            string obj= null;
            switch (choice)
            {
                case "1":
                    obj = "Contact";
                    break;
                case "2":
                    obj = "Book";
                    break;
                case "3":
                    obj = "Car";
                    break;
                case "4":
                    obj = "Student";
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            while (obj != null)
            {
                Console.WriteLine($"\n--- Searching in {obj} ---");
                int index = -1;

                switch (obj)
                {
                    case "Contact":
                        Console.WriteLine("Search by: 1.First Name | 2.Last Name | 3.Phone");
                        string cAttr = Console.ReadLine();
                        Console.Write("Enter keyword: ");
                        string cKey = Console.ReadLine().ToLower();
                        index = Searching.LinearSearchGeneric(friends, f =>
                            (cAttr == "1" && f.GetFirstName().ToLower().Contains(cKey)) ||
                            (cAttr == "2" && f.GetLastName().ToLower().Contains(cKey)) ||
                            (cAttr == "3" && f.ToString().Contains(cKey)));
                        break;

                    case "Book":
                        Console.WriteLine("Search by: 1.Title | 2.Author");
                        string bAttr = Console.ReadLine();
                        Console.Write("Enter keyword: ");
                        string bKey = Console.ReadLine().ToLower();
                        index = Searching.LinearSearchGeneric(books, b =>
                            (bAttr == "1" && b.ToString().ToLower().Split('\t')[0].Contains(bKey)) ||
                            (bAttr == "2" && b.ToString().ToLower().Contains(bKey)));
                        break;

                    case "Car":
                        Console.WriteLine("Search by: 1.Year | 2.Brand/Model");
                        string carAttr = Console.ReadLine();
                        Console.Write("Enter keyword: ");
                        string carKey = Console.ReadLine().ToLower();
                        index = Searching.LinearSearchGeneric(cars, c =>
                            (carAttr == "1" && c.ToString().StartsWith(carKey)) ||
                            (carAttr == "2" && c.ToString().ToLower().Contains(carKey)));
                        break;

                    case "Student":
                        Console.WriteLine("Search by: 1.Name | 2.GPA");
                        string sAttr = Console.ReadLine();
                        Console.Write("Enter keyword: ");
                        string sKey = Console.ReadLine().ToLower();
                        index = Searching.LinearSearchGeneric(students, s =>
                            (sAttr == "1" && s.ToString().ToLower().Contains(sKey)) ||
                            (sAttr == "2" && s.ToString().Contains(sKey)));
                        break;
                }

                if (index != -1)
                {
                    // Hiển thị kết quả dựa trên Object đang chọn
                    object foundObj = (obj == "Contact") ? friends[index] :
                                     (obj == "Book") ? books[index] :
                                     (obj == "Car") ? (object)cars[index] : students[index];
                    Console.WriteLine($"[SUCCESS] Found at index {index}: {foundObj}");
                }
                else
                {
                    Console.WriteLine("[FAILED] No match found.");
                }

                // Cho phép người dùng chọn lại hoặc thoát
                Console.WriteLine("\nSearch another object? (1:Contact, 2:Book, 3:Car, 4:Student, 0:Exit)");
                string next = Console.ReadLine();
                if (next == "0") break;
                obj = (next == "1") ? "Contact" : (next == "2") ? "Book" : (next == "3") ? "Car" : (next == "4") ? "Student" : null;
            }
        }
    }
}