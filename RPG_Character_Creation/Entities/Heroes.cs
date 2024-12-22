using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_de_Projeto.Entities
{
    public abstract class Heroes
    {
       public string Name { get; set; }

       public int Level { get; set; }

       public string HeroType { get; set; } 

       public string Weapon { get; set; }
       
       public int Hp { get; set; }

       public int Mp { get; set; }

    //Construtores:
    public Heroes()
    {

    }
    public Heroes (string Name, int Level, string HeroType, string Weapon)
    {
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;
        this.Weapon = Weapon;
    }

    //Métodos:
    public override string ToString()
    {
        this.Hp = Hp;
        this.Mp = Mp;
        return "Name: " + this.Name + "\n" + "Level: " + this.Level + "\n" + "Type: " + this.HeroType + "\n" + "HP: " + this.Hp + "\n" + "MP: " + this.Mp + "\n";
    }

    public virtual string Attack()
    {
        return this.Name + " Attacked with a " + this.Weapon + "!";
    }

    }
}