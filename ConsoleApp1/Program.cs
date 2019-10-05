using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("My name is Tom");
            Console.WriteLine(7.5);
            Console.WriteLine(BritEnum.Exotic);


            Cat cat1 = new Cat ("Vaska", 10.1f, BritEnum.Brit);
            Console.WriteLine(cat1.Name);
            Console.WriteLine(cat1.Age);
            Console.WriteLine(cat1.brit);

            //Cat cat2 = new Cat("Barsik", 3);
            //Console.WriteLine(cat2.Name);
            //Console.WriteLine(cat2.Age);
            //Console.WriteLine(cat2.brit);

            //Cat cat3 = new Cat("Murzik", 4, BritEnum.None);
            //Console.WriteLine(cat3.Name);
            //Console.WriteLine(cat3.Age);
            //Console.WriteLine(cat3.brit);


            //Console.WriteLine(cat1);

            //Console.WriteLine(Cat.LegCount);

            cat1.Name = "ZZZ";
            Console.WriteLine(cat1.Name);

        }
    }
}
