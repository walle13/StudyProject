using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//“派生”也叫“继承”，在原有某个类的基础上，扩展新的功能。

namespace EventExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyForm form = new MyForm();
            form.Click += form.FormAction;
            // ctrl + . 回车;自动在MyForm类里面,声明事件处理器.
            form.ShowDialog();

        }
    }
    class MyForm : Form
    {
        internal void FormAction(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString(); //设置自己的标题栏 Text,设置为 时间.
        }
    }
    //“派生”也叫“继承”，在原有某个类的基础上，扩展新的功能。
    //MyForm ,子类； Form,基类，父类
}
