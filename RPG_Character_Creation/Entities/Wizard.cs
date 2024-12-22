using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_de_Projeto.Entities
{
    public class Wizard : Heroes
    {
        public Wizard(string Name, int Level, string HeroType, string Weapon)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Weapon = Weapon;
        }

        public override string Attack()
        {
            return this.Name + " cast a spell with a " + this.Weapon + "!";
        }

        public override string ToString()
        {
            this.Hp = Level * 6;
            this.Mp = Level * 12;
            return "Name: " + this.Name + "\n" + "Level: " + this.Level + "\n" + "Type: " + this.HeroType + "\n" + "HP: " + this.Hp + "\n" + "MP: " + this.Mp + "\n";
    
        }
    }
}