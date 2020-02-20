using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human wizard = new Human("Gandalf", 10,10,10,100);
            // Console.WriteLine($"{wizard.Name} hits for {wizard.Strength * 5}");
            Human orc = new Human("Orcboy");
            int attack = wizard.Attack(orc);
            Console.WriteLine(orc.health);
        }
    }

    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int Health;//instructor adrien told me to make this public >:)
        public Human(string name)
        {
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        public Human(string name, int str, int intel, int dex, int health)
        {
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            Health = health;
        }
        public string health{
            get {return $"{Health} health remaining.";}
        }
        public int Attack(Human target)
        {
            int humanAttack = Strength * 5;
            // Console.WriteLine(humanAttack);
            target.Health = target.Health - humanAttack;
            // Console.WriteLine(target.Health);
            return target.Health;
            
        }
    }
}
