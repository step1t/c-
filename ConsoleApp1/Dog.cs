using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  
        public class Dog : Pet
        {
            public override string Say()
            {
                return "Woof";
            }
        public override string Move()
        {
            return "run";
        }

    }
    
}
