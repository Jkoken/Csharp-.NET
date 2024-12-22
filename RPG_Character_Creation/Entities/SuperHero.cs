using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_de_Projeto.Entities
{
    public class SuperHero : Heroes
    {
        public SuperHero(string Name, int Level, string HeroType, string Weapon)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Weapon = Weapon;
        }

        public override string Attack()
        {
            return this.Name + " a supreme attack with his " + this.Weapon  + "!";
        }

        public string Attack(int Bonus) //Exemplo de Polimorfismo com o método Attack() acima;
        {
            if (Bonus >= 100)
            {
                return this.Name + " hit a supreme attack with his " + this.Weapon + ", with damage bonus of " + Bonus + "!!!";
            } else if (Bonus >= 50){
                return this.Name + " hit a super effective attack with his " + this.Weapon + ", with damage bonus of " + Bonus + "!!!";
            } else if (Bonus >= 15){
                return this.Name + " hit an effective attack with his " + this.Weapon + ", with damage bonus of " + Bonus + "!!!";
            }
            return this.Name + " hit an attack with his " + this.Weapon + ", with damage bonus of " + Bonus + "!!!";
        }

        public override string ToString()
        {
            this.Hp = Level * 12;
            this.Mp = Level * 8;
            return "Name: " + this.Name + "\n" + "Level: " + this.Level + "\n" + "Type: " + this.HeroType + "\n" + "HP: " + this.Hp + "\n" + "MP: " + this.Mp + "\n";
    
        }
    }
}