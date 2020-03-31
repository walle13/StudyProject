using System;

namespace IspExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IKiller killer = new WarmKiller();
            killer.Kill();
            var wk = (IGentleman)killer;
            wk.Love();
        }
    }

    interface IGentleman
    { 
        void Love();
    }

    interface IKiller
    {
        void Kill();
    }

    class WarmKiller : IGentleman, IKiller
    {
        




        public void Love()
        {
            Console.WriteLine("I will love you for ever ...");
        }

        void IKiller.Kill()     //***接口的显示实现
        {
            Console.WriteLine("Let me kill the enemy ...");
        }
    }
}
