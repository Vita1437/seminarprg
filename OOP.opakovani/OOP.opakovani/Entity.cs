using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP.opakovani
{
    internal abstract class Entity
    {
        public string name;
        public int hp;

        public Entity(int hp, string name)
        {
            this.hp = hp;
            this.name = name;

        }
        PropertyInfo[] properties;
        public void introduction()
        {
                Console.WriteLine("This is " +  name + ".\nHe has got" + hp + " hp.");
        }
        public virtual void TestFunction()
        {
            Console.WriteLine("Writing from testfunction");
        }
    }
}
