using System;

namespace AppName
{
    
    abstract class Person
    {
        //Đóng gói: các trường riêng có thuộc tính chung
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Phương thức trừu tượng để thể hiện tính đa hình
        public abstract void PrintInfo();
    }

    // Interface
    interface IStudent
    {
        bool IsEligibleForCourse();
    }

    // kế thừa
    class Student : Person, IStudent
    {
        
        public Student(string name, int age) : base(name, age)
        {
        }

        
        public Student(string name) : base(name, 18)
        {
        }

        // Overriding ghi đè
        public override void PrintInfo()
        {
            Console.WriteLine("Tên: {0}", Name);
            Console.WriteLine("Tuổi: {0}", Age);
        }

        
        public bool IsEligibleForCourse()
        {
            return Age >= 18;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
          /*  int age; // Khai báo biến age kiểu int (số nguyên)
            age = 25; // Gán giá trị 25 cho biến age

            int age = 25; // Kiểu int (số nguyên)
            double salary = 1000.50; // Kiểu double (số thực)
            bool isStudent = true; // Kiểu bool (boolean)
            string name = "thanh"; // Kiểu string (chuỗi)

            int age = 20;
            if (age >= 18)
            {
                Console.WriteLine("Bạn đã đủ tuổi để lái xe.");
            }
            else
            {
                Console.WriteLine("Bạn chưa đủ tuổi để lái xe.");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Giá trị của i là: " + i);
            }
          //làm việc với chuối
            string greeting = "Xin chào";
            string name = "thanh";
            string message = greeting + ", " + name + "!";
            Console.WriteLine(message);
*/


            List<Student> students = new List<Student>
            {
                new Student("Nguyễn Văn A", 20),
                new Student("Trần Thị B", 17),
                new Student("Lê Văn C", 19)
            };

            // vòng lặp
            foreach (var student in students)
            {
                student.PrintInfo();
                Console.WriteLine("Có đủ điều kiện tham gia khóa học: {0}", student.IsEligibleForCourse());
                Console.WriteLine();
            }
        }
    }
}
