using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMemberExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stuList = new List<Student>();
            for (int i = 0; i < 100; i++)
            {
                Student stu = new Student();
                stu.Age = 24;
                stu.Score = i;
                stuList.Add(stu);
            }

            int totalAge = 0;
            int totalScore = 0;
            foreach (var stu in stuList)
            {
                totalAge += stu.Age;
                totalScore += stu.Score;
            }
            Student.AverageAge = totalAge / Student.Amount;
            Student.AverageScore = totalScore / Student.Amount;

            Student.RepertAmount();
            Student.ReportAverageAge();
            Student.ReportAverageScore();

            Console.ReadLine();
        }
    }
    class Student
    {
        public int Age;
        public int Score;

        public static int AverageAge;
        public static int AverageScore;
        public static int Amount;

        public Student()
        {
            Student.Amount++;
        }

        public static void RepertAmount()
        {
            Console.WriteLine(Student.Amount);
        }

        public static void ReportAverageAge()
        {
            Console.WriteLine(Student.AverageAge);
        }

        public static void ReportAverageScore()
        {
            Console.WriteLine(Student.AverageScore);
        }
    }
}
