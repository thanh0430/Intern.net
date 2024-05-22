using System;

namespace AppName
{
    //Thuộc tính (property)
    public class Person
    {
        // Trường dữ liệu (field)
        private string name;

        // Thuộc tính (property)
        public string Name
        {
            get { return name; }  // getter
            set { name = value; } // setter
        }

        // Thuộc tính tự động (auto-implemented property)
        public int Age { get; set; }
    }
    // các phương thức
    public class Calculator
    {
        // Phương thức không trả về giá trị (void) và không có tham số
        public void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Calculator!");
        }

        // Phương thức trả về giá trị (int) và có tham số
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Phương thức trả về giá trị (double) và có tham số
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return a / b;
        }
    }

    // ham khơi tạo constructor
    public class sinhvien
    {
        public string Name;
        public int Age;

        // Hàm khởi tạo có tham số
        public sinhvien(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    //nap chong overload
    public class Hocsinh
    {
        public string Name;
        public int Age;

        // Hàm khởi tạo mặc định
        public Hocsinh()
        {
            Name = "Unknown";
            Age = 0;
        }

        // Hàm khởi tạo có một tham số
        public Hocsinh(string name)
        {
            Name = name;
            Age = 0;
        }

        // Hàm khởi tạo có hai tham số
        public Hocsinh(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    public class Animal
    {
        // Phương thức virtual cho phép lớp con ghi đè
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }
    public class Dog : Animal
    {
        // Ghi đè phương thức Speak
        public override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    public class Cat : Animal
    {
        // Ghi đè phương thức Speak
        public override void Speak()
        {
            Console.WriteLine("The cat meows.");
        }
    }

    public abstract class Animal1
    {
        // Phương thức trừu tượng không có phần thân
        public abstract void Speak();

        // Phương thức bình thường có phần thân
        public void Sleep()
        {
            Console.WriteLine("The animal is sleeping.");
        }
    }
    public class Dog1 : Animal1
    {
        // Triển khai phương thức trừu tượng
        public override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    public class Cat1 : Animal1
    {
        // Triển khai phương thức trừu tượng
        public override void Speak()
        {
            Console.WriteLine("The cat meows.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           /*   int age; // Khai báo biến age kiểu int (số nguyên)
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
              Console.WriteLine(message)*/;

          
            // Tạo một đối tượng Person
            Person person = new Person();

            // Sử dụng thuộc tính Name
            person.Name = "John";  // gọi setter
            Console.WriteLine(person.Name); // gọi getter

            // Sử dụng thuộc tính tự động Age
            person.Age = 30;
            Console.WriteLine(person.Age);

            //phương thức
            // Tạo một đối tượng Calculator
            Calculator calculator = new Calculator();

            // Gọi phương thức không trả về giá trị
            calculator.PrintWelcomeMessage();

            // Gọi phương thức có trả về giá trị
            int sum = calculator.Add(5, 3);
            Console.WriteLine("Sum: " + sum);

            // Gọi phương thức có trả về giá trị với xử lý ngoại lệ
            try
            {
                double result = calculator.Divide(10, 2);
                Console.WriteLine("Division Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //hàm khởi tạo
            sinhvien sinhvien = new sinhvien("thanh", 22);
            Console.WriteLine($"Name: {sinhvien.Name}, Age: {sinhvien.Age}");

            // overload
            Hocsinh Hocsinh = new Hocsinh();
            Hocsinh Hocsinh1 = new Hocsinh("nguyen");
            Hocsinh Hocsinh2 = new Hocsinh("thanh", 22);

            Console.WriteLine($"Person 1: Name: {Hocsinh.Name}, Age: {Hocsinh.Age}");
            Console.WriteLine($"Person 2: Name: {Hocsinh1.Name}, Age: {Hocsinh1.Age}");
            Console.WriteLine($"Person 3: Name: {Hocsinh2.Name}, Age: {Hocsinh2.Age}");

            //override
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            myAnimal.Speak();  // Output: The animal makes a sound.
            myDog.Speak();     // Output: The dog barks.
            myCat.Speak();     // Output: The cat meows.
        }
    }
}
