using System;

namespace InterfaceExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new PhoneUser(new EricssonPhone());      //引用接口，耦合变得很松
           // var user = new PhoneUser(new NokiaPhone());
            user.UsePhone();
            Console.WriteLine("Hello World!");
        }
    }

    class PhoneUser
    {
        private IPhone _phone;
        public PhoneUser(IPhone phone)
        {
            _phone = phone;
        }

        public void UsePhone()
        {
            _phone.Dail();
            _phone.PickUp();
            _phone.Send();
            _phone.Receive();
        }

    }


    interface IPhone
    {
        void Dail();
        void PickUp();
        void Send();
        void Receive();
    }

    class NokiaPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Nokia calling...");
        }

        public void PickUp()
        {
            Console.WriteLine("Hello! This is Tim !");
        }

        public void Receive()
        {
            Console.WriteLine("Nokia massage ring...");
        }

        public void Send()
        {
            Console.WriteLine("Hello!");
        }
    }

    class EricssonPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("EricssonPhone calling...");
        }

        public void PickUp()
        {
            Console.WriteLine("Hi! This's Tim!");
        }

        public void Receive()
        {
            Console.WriteLine("Ericsson ring...");
        }

        public void Send()
        {
            Console.WriteLine("Good evening!");
        }
    }
}
