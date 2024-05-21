using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern.net
{
    internal class Functions
    {
        public class Calculator
        {
            public int Add(int a, int b) // Phương thức cộng
            {
                return a + b;
            }

            public int Subtract(int a, int b) // Phương thức trừ
            {
                return a - b;
            }

            public void PrintMessage() // Phương thức không trả về giá trị
            {
                Console.WriteLine("Hello from Calculator class!");
            }
        }
    }
}
