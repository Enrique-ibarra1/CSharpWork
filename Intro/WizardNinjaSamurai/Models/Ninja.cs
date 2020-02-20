using System;
namespace WizardNinjaSamurai.Models
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            base.Dexterity = 175;
        }

        public override int Attack(Human target)
        {
            int hp = Dexterity * 5;
            Random rand = new Random();
            Console.WriteLine($"{Name} attacked {target.Name} for {hp} damage! Overkill?");
            if(rand.Next(0,5) == 0)
            {
                hp += 10;
                Console.WriteLine($"{Name} applied bleed. Uhh dude just hit for like 800 damage but you're bleeding now too i guess.");
            }
            return target.Damage(hp);
        }

        public void Steal(Human target)
        {
            target.Damage(5);
            Heal(5);
            Console.WriteLine($"{Name} took 5 health from {target.Name}. Stealing is bad");

        }
    }
}