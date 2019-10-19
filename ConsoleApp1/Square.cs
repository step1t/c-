using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Square : CommonFigure
    {
        public override void Print()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*********");
            Console.WriteLine("*       *");
            Console.WriteLine("*       *");
            Console.WriteLine("*       *");
            Console.WriteLine("*********");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
