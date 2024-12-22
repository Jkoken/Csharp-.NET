using System;
using Desafio_de_Projeto.Entities;

namespace Desafio_de_Projeto
{
    class Program
    {
        static void Main (string[] args)
        {
            Knight knight1 = new Knight("Arus", 44, "Knight", "Sword");
            Ninja ninja1 = new Ninja("Wedge", 42, "Ninja", "Dagger");
            Wizard wizard1 = new Wizard("Jennica", 42, "White Wizard", "Staff");
            SuperHero superHero = new SuperHero("Link", 99, "Hero", "Sacred Sword");

            // string Name = Console.ReadLine();
            // int Level = int.Parse(Console.ReadLine());
            // string HeroType = Console.ReadLine();
            // string Weapon = Console.ReadLine();
            // Knight knight2 = new Knight(Name, Level, HeroType, Weapon);

            Console.WriteLine(knight1.ToString());
            Console.WriteLine(ninja1);
            Console.WriteLine(wizard1);
            Console.WriteLine(superHero);
            // Console.WriteLine(knight2);

            Console.WriteLine(knight1.Attack());
            Console.WriteLine(ninja1.Attack());
            Console.WriteLine(wizard1.Attack());
            Console.WriteLine(superHero.Attack() + 
                                "\n" + superHero.Attack(100) + 
                                "\n" + superHero.Attack(50) +
                                "\n" + superHero.Attack(15) +
                                "\n" + superHero.Attack(10));
            // Console.WriteLine(knight2.Attack());
        }
    }
}