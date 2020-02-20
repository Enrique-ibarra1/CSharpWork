using System;
namespace WizardNinjaSamurai.Models
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            base.health = 50;
            base.Intelligence = 22;
        }

        public override int Attack(Human target)
        {
            int hp = Intelligence * 5;
            Heal(hp);
            Console.WriteLine($"{Name} attacked {target.Name} for {hp} damage!");
            return target.Damage(hp);
        }

        public int Regeneration(Human target)//Wizards healing spell :)
        {
            int hp = Intelligence * 10;
            Console.WriteLine($"{Name} healed {target.Name} for {hp} health. How nice!");
            return target.Heal(hp);
        }
    }
}