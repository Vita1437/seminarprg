using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.opakovani
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double x = Math.PI;
            decimal n = 1 / 4;
            Console.WriteLine(n);
            Random.ReferenceEquals(x, n);
            Random rng = new Random(4);
            Console.WriteLine(rng.Next(10, 100));
            Console.WriteLine(rng.Next(10, 100));
            Console.WriteLine(rng.Next(10, 100));
            

            //Entity karel = new Entity(34, "karlos");
            //karel.introduction();

            Player dawg = new Player(34, "Dawg", 300, "mage");
            dawg.introduction();

            NPC merchant = new NPC(10, "Glazuroid", "a", 1);
            merchant.introduction();

            dawg.TestFunction();
            merchant.TestFunction();
            Console.ReadKey();
        }
    }
}
