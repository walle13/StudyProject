using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            //事件的拥有者 **form
            Controller controller = new Controller(form);   //创建一个实例，传入一个form
            //事件的响应者 **controller
            form.ShowDialog();  //调用ShowDialog（）的方法
        }
    }

    class Controller
    {
        private Form form;  //添加一个form类型字段
        public Controller(Form form)       //添加一个构造器(构造方法)，能够接受一个form类型的参数
        {
            if (form!=null) //如果对象不等于空，
            {
                this.form = form;   //实例字段。 用this区分，哪个是我的字段，哪个是我的参数
                this.form.Click += this.FormClicked;    //创建一个form的，添加click事件处理，挂接一个事件处理器。FormClicked实例的方法。

                //事件    **Click
                //事件处理器 **this.FormClicked
                //事件订阅  **this.form.Click += this.FormClicked;
            }
        }

        private void FormClicked(object sender, EventArgs e)    //声明一个 FormClicked 实例方法，事件处理器
        {
            this.form.Text = DateTime.Now.ToString();
        }
    }

}
