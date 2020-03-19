using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductFactory productFactory = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();

            Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
            Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);

            Logger logger = new Logger();
            Action<Product> log = new Action<Product>(logger.Log);

            Box box1 = wrapFactory.WrapProduct(func1, log);
            Box box2 = wrapFactory.WrapProduct(func2, log);

            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);

            Console.ReadLine();
        }
    }

    class Logger
    {
        public void Log(Product product)
        {
            Console.WriteLine("Product '{0}'created at {1}.Price is {2}.", product.Name, DateTime.UtcNow, product.Price);
        }
    }
    class Product   //生产类
    { 
        public string Name { get; set; }    //通过该属性的 get 和 set 访问器访问的专用、匿名支持字段
                    //当属性访问器中不需要任何其他逻辑时，自动实现的属性会使属性声明更加简洁。
        public double Price { get; set; }
    }
    class Box   //包装箱类
    {
        public Product Product{ get; set; } //有个product 属性
    }
    class WrapFactory   //包装工厂
    {
        public Box WrapProduct(Func<Product> getProduct,Action<Product> logCallback)    //WrapProduct方法
        {
            Box box = new Box();
            Product product = getProduct.Invoke();
            if (product.Price>=50)
            {
                logCallback(product);
            }

            box.Product = product;
            box.Product = product;
            return box;
        }
    }
    class ProductFactory    //生产工厂
    {
        public Product MakePizza()
        {
            Product product = new Product();
            product.Name = "Pizza";
            product.Price = 12;
            return product;
        }
        public Product MakeToyCar()
        {
            Product product = new Product();
            product.Name = "Toy Car ";
            product.Price = 100;
            return product;
        }
    }
}
