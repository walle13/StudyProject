using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person persion1 = new Person();
            Person persion2 = new Person();
            persion1.Name = "Deer";
            persion2.Name = "Deer's wife";
            //List<Person> nation = Person.GetMarry(persion1, persion2);
            List<Person> nation = persion1 + persion2; 
            foreach (var p in nation)   //据说是循环访问集合，list
            {
                Console.WriteLine(p.Name);
            }
            Console.ReadLine();

        }
    }
    class Person
    {
        public string Name;
        //public static List<Person> GetMarry(Person p1, Person p2) // 创建一个 GetMarry的方法
        public static List<Person> operator +(Person p1, Person p2) //将 操作符（operator 关键字） “+”替换这个 方法 名
        {
            List<Person> people = new List<Person>();
            people.Add(p1);     //list 添加第一个
            people.Add(p2);      //list 添加第二个
            for (int i = 0; i < 11; i++)
            {
                Person child = new Person();
                child.Name = p1.Name + " & " + p2.Name + "s child";
                people.Add(child);
            }
            return people;
        }
    }
}
