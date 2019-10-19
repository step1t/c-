using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cat : Pet
    {
        public string Name;
        public float Age;
        public BritEnum brit;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine(Age.ToString());
            return sb.ToString();
        }

        public override string Say()
        {
            return "Meow";
        }

        public override string Move()
        {
            return "step";
        }

        //public Cat(string name, float age, BritEnum brit = BritEnum.Brit)
        //{
        //    this.Name = name;
        //    this.Age = age;
        //    this.brit = brit;
        //}

    } 
}
