using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Student stu = new Student() { ID = 1, Name = "Timothy" };

            /*      //实例构造器
            Student stu = new Student(1,"Timothy") ;  
            Console.WriteLine(stu.ID);
            Console.WriteLine(stu.Name);
            stu.Report();
             */

            // 托管里面的  反射
            Type t = typeof(Student);
            object o = Activator.CreateInstance(t, 1, "Timothy");
            Student stu = o as Student;
            Console.WriteLine(stu.Name);


            Console.ReadLine();
        }
    }

    class Student
    {
        public Student(int id,string name)            //stor + "tab" 两下，可以快速构建， student()构造器
        {
            this.ID = id;
            this.Name = name;
         
        }

        /*
        ~Student()  //析构器
        {
            Console.WriteLine("Bye bye! Release the system resources ...");
        }*/

        public int ID { get; set; }
        public string Name { get; set; }
        public void Report()
        {
            Console.WriteLine($"I'm #{ID} student,my name is {Name}.");
        }
    }
}
