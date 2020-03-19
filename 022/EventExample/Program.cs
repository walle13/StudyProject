using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            customer.Order += waiter.Action;
            customer.Action();
            customer.PayTheBill();

            Console.ReadLine();
        }
    }

    public class OrderEventArgs:EventArgs
    { 
        public string DishName { get; set; }
        public string Size { get; set; }
    }

    public delegate void OrderEventHandler(Customer customer,OrderEventArgs e); //委托跟类同级
    public class Customer
    {
        /*
        private OrderEventHandler orderEventHandler;

        public event OrderEventHandler Order
        {
            add 
            {
                this.orderEventHandler += value;    //价值
            }
            remove
            {
                this.orderEventHandler -= value;
            }

        }
         //以上是声明事件的代码
             */
        public event OrderEventHandler Order;       //简写的事件声明

        public double Bill { get; set; }
        public void PayTheBill()
        {
            Console.WriteLine("I will pay ${0}",this.Bill);
        }

        public void WalkIN()
        {
            Console.WriteLine("Walk into the reataurant.");
        }
        public void SitDown()
        {
            Console.WriteLine("Sit down.");
        }
        public void Think()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Let me think ...");
                Thread.Sleep(1000);
            }
            /*

            if (this.orderEventHandler != null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = "Kongpao Chicken";
                e.Size = "large";
                this.orderEventHandler.Invoke(this,e);  //invoke 调用
            }
            */

            if (this.Order != null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = "Kongpao Chicken";
                e.Size = "large";
                this.Order.Invoke(this, e);  //invoke 调用
            }
        }

        public void Action()
        {
            Console.ReadLine();
            this.WalkIN();
            this.SitDown();
            this.Think();
        }
    }
    public class Waiter
    {
        public void Action(Customer customer, OrderEventArgs e)
        {
            Console.WriteLine("I will serve you the dish-{0}",e.DishName);
            double price = 10;
            switch (e.Size)
            {
                case "small":
                    price = price * 0.5;
                    break;
                case "large":
                    price = price * 1.5;
                    break;
                default:
                    break;
            }

            customer.Bill += price;
        }
    }

}


//事件是基于委托的. +事件需要委托类型做约束.