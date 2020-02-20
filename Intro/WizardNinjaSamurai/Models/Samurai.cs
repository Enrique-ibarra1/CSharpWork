using System;
namespace WizardNinjaSamurai.Models
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            base.health = 200;
        }

        public override int Attack(Human target)
        {
            if (target.Health < 50)
            {
                Console.WriteLine($"{Name} got a killing blow on {target.Name}");
                return target.Damage(target.Health);
            }
            return base.Attack(target);
        }

        public void Meditate()
        {
            health = 200;
            Console.WriteLine($"{Name} took a break and regenerated all wounds.");
        }
    }
}