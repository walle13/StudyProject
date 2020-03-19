using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorExample
{

    class Program
    {/*
        static void Main(string[] args)
        {
            Dictionary<string, Student> stuDic = new Dictionary<string, Student>();
            for (int i = 1; i <= 100; i++)
            {
                Student stu = new Student();
                stu.Name = "s_" + i.ToString();
                stu.Score = 100 + i;
                stuDic.Add(stu.Name, stu);
            }

        }
    }
    class Student
    {
        public string Name;
        public int Score;
        */

        /*  typeof 操作符
           static void Main(string[] args)
           {
               Type t = typeof(int); //于获取类型的 System.Type 对象. typeof  查看一个类的内部结构：源数据 Metadata
               Console.WriteLine(t.Namespace);
               Console.WriteLine(t.FullName);
               Console.WriteLine(t.Name);
               int c = t.GetMethods().Length;  //返回为当前 Type 的所有公共属性,长度。
               foreach (var mi in t.GetMethods())
               {
                   Console.WriteLine(mi.Name);
               }
               Console.WriteLine(c);
               Console.ReadLine();

           }
           */


        /*   default操作符
        static void Main(string[] args)
        {
            Form myForm = default(Form); //于获取类型的 System.Type 对象. typeof  查看一个类的内部结构：源数据 Metadata
            Console.WriteLine(myForm);
            Console.ReadLine();

        }
        */
        static void Main(string[] args)
        {
            Form myform = new Form() { Text = "Hello" };
            var person = new { Name = "Mr.Okay", Age = 34 };        // 用"var"关键字，用匿名类型创造变量
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.GetType().Name);

            uint x = uint.MaxValue;     //定义x 是uint型最大值
            Console.WriteLine(x);
            string binStr = Convert.ToString(x, 2); //将x 转换成二进制字符串
            Console.WriteLine(binStr);
            checked  
            {
                try
                {
                    uint y = checked(x + 1);
                    Console.WriteLine(y);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("There's overflow");
                }
            }       //checked  检查溢出；unchecked,不检查溢出

            Console.ReadLine();

        }
    }
}
