using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.opakovani
{
    internal class NPC : Entity
    {
        string attitude;
        int friendliness;
        public NPC(int health, string name, string attitude, int friendliness) : base(health, name)
        {
            this.attitude = attitude;
            this.friendliness = friendliness;
        }
        public void Dialog(Player player, string message)
        {
      
        }
        public override void TestFunction()
        {
            Console.WriteLine("Writing from npc");
        }

    }
}
