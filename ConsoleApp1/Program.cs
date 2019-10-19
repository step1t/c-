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
            int i;

            var Sq = new Square();
            var Tri = new Triangle();
            var Rh = new Rhomb();


            do
            {
                Console.Write("Меню:\n1) Вывести на экран квадрат" +
                                   "\n2) Вывести на экран треугольник" +
                                   "\n3) Вывести на экран ромб" +
                                   "\n4) Выйти из программы\n\nВаше решение: ");
                i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Sq.Print();
                        break;
                    case 2:
                        Tri.Print();
                        break;
                    case 3:
                        Rh.Print();
                        break;
                    case 4:
                        Console.WriteLine("Вы решили выйти");
                        break;
                    default:
                        Console.WriteLine("Вы что-то другое нажали...");
                        break;
                }
                Console.Write("\n\n\t\t\tНажмите любую клавишу...");
                Console.ReadLine();
                Console.Clear();
            }
            while (i != 4);

 
        //    var cat1 = new Cat();
        //    Console.WriteLine(cat1.Say());

        //    var dog1 = new Dog();
        //    Console.WriteLine(dog1.Say());
        //    Console.WriteLine(dog1.Move());  // если закоментить, то будет иное поведение
            
        //    var parrot1 = new Parrot();
        //    Console.WriteLine(parrot1.Say());

        //    var array = new Pet[3];
        //    array[0] = cat1;
        //    array[1] = dog1;
        //    array[2] = parrot1;

        //    foreach(Pet pet in array)
        //    {
        //        Console.WriteLine(pet.Say());
        //        Console.WriteLine(pet.Move());
        //    }


        //var str = Console.ReadLine();
        //    var str2 = Console.ReadLine();

        //    bool isAValid = Int32.TryParse(str, out int a);
        //    bool isBValid = Int32.TryParse(str2, out int b);
        //    if (!isAValid || !isBValid)
        //    {
        //        Console.WriteLine("Invalid input");
        //    }
        //    else
        //    {
        //        Console.WriteLine(a + b);
        //    }


        //    //var result = str + str2;
            //Console.WriteLine(result);

            //int a = Int32.Parse(str);
            //int b = Int32.Parse(str2);
            //var result1 = a + b;
            //Console.WriteLine(result1);
            
            //Console.WriteLine("My name is Tom");
            //Console.WriteLine(7.5);
            //Console.WriteLine(BritEnum.Exotic);


            //Cat cat1 = new Cat ("Vaska", 10.1f, BritEnum.Brit);
            //Console.WriteLine(cat1.Name);
            //Console.WriteLine(cat1.Age);
            //Console.WriteLine(cat1.brit);

            ////Cat cat2 = new Cat("Barsik", 3);
            ////Console.WriteLine(cat2.Name);
            ////Console.WriteLine(cat2.Age);
            ////Console.WriteLine(cat2.brit);

            ////Cat cat3 = new Cat("Murzik", 4, BritEnum.None);
            ////Console.WriteLine(cat3.Name);
            ////Console.WriteLine(cat3.Age);
            ////Console.WriteLine(cat3.brit);


            ////Console.WriteLine(cat1);

            ////Console.WriteLine(Cat.LegCount);

            //cat1.Name = "ZZZ";
            //Console.WriteLine(cat1.Name);

        }
    }
}
