using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.opakovani
{
    internal class Player : Entity, iDemageable
    {
        int money;
        string proffesion;
        private string[] proffesions = { "mage", "knight", "archer" };
        public string DamageType { get; set; }
        public Player(int health,  string name, int money, string proffesion) : base(health, name)
        {
            this.money = money;
            if (proffesions.Contains(proffesion))
            {
                this.proffesion = proffesion;
            }
            else
            {
                this.proffesion = proffesions[0];
            }
        }

        



        public void GetDamage()
        {
            if (hp > 0)
            {
                hp--;
                if (hp <= 0)
                {
                    SimulateDeath();
                }
            }
            
        }
        private void SimulateDeath()
        {

        }
    }
}
