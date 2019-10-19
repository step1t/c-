using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Triangle : CommonFigure
    {
        public override void Print()
        {
            Console.WriteLine("    *    ");
            Console.WriteLine("  *   *  ");
            Console.WriteLine("*       *");
            Console.WriteLine("*********");
        }
    }
}
