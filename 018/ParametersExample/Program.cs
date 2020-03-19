using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = null;
            bool b = StudentFactory.Create("Tim",34,out stu);
            if (b == true)
            {
                Console.WriteLine("Student {0},age is {1}.", stu.Name, stu.Age);
                Console.ReadLine();
            }
        }
    }

    class Student
    { 
        public int Age { get; set; }
        public string Name { get; set; }

    }
    class StudentFactory
    {
        public static bool Create(string stuName, int stuAge, out Student result)
        {
            result = null;
            if (string.IsNullOrEmpty(stuName))      // IsNullOrEmpty 判断是否为空
            {
                return false;
            }

            if (stuAge < 20 || stuAge > 80)
            {
                return false;

            }
            result = new Student() { Name = stuName, Age = stuAge };
            return true;
        }
    }

}

