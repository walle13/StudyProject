using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace TypeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(Form);
            PropertyInfo[] pInfos = myType.GetProperties();
            Console.WriteLine(myType.BaseType.FullName);
            foreach (var p in pInfos)   //语句用于循环访问集合
            {
                Console.WriteLine(p.Name);
            }

            Console.ReadLine();
          
        }
    }
}
