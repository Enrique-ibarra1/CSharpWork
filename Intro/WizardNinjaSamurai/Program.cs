using System;
using WizardNinjaSamurai.Models;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Gandalf = new Wizard("Gandalf");
            Ninja Naruto = new Ninja("Naruto");
            Samurai Mugen = new Samurai("Mugen");
            Gandalf.Attack(Naruto);
            Gandalf.Regeneration(Naruto);
            Naruto.Attack(Mugen);
            Mugen.Attack(Gandalf);
            Mugen.Attack(Gandalf);
            Naruto.Steal(Gandalf);
        }
    }
}
