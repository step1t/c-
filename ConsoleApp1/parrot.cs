using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Parrot : Pet
        {
            public override string Say()
        {
            return "kudah";
        }

        public override string Move()
        {
            return "fly";
        }
    }
}

