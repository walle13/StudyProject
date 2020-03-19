using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp1
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
            //this.myButton.Click += MyButton_Click;    //挂接事件处理器
          //  this.myButton.Click += new EventHandler(this.MyButton_Click);
            this.button2.Click += (sender, e)=>
            {
                 this.myTextBox.Text = "ha ha!";
             };
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            if (sender == this.button1)
            {
                this.myTextBox.Text = "Hello";
            }
            if (sender==this.myButton)
            {
                this.myTextBox.Text = "World";
            }

            if (sender==this.button2)
            {
                this.myTextBox.Text = "Mr.Okay";
            }
        }
    }
}
