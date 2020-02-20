using System;
using System.Collections.Generic;
using HungryNinja.Models;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            // Food toEat = buffet.Serve();
            SweetTooth timmy = new SweetTooth();
            SpiceHound spicy = new SpiceHound();

            while(timmy.IsFull ==false)
            {
                timmy.Consume(buffet.Serve());
                Console.WriteLine("Timmy eating");
                if(timmy.IsFull == true)
                {
                    Console.WriteLine("Timmy full no more food");
                }
            }

            while(spicy.IsFull == false)
            {
                spicy.Consume(buffet.Serve());
                Console.WriteLine("Spicy eating");
                if(spicy.IsFull == true)
                {
                    Console.WriteLine("Spicy on fire plese no more it burn");
                }
            }

            int timmyCount = timmy.ConsumableHistroy.Count;
            int spicyCount = timmy.ConsumableHistroy.Count;
            if (timmyCount > spicyCount)
            {
                Console.WriteLine($"Timmy has eaten more than spicy, {timmyCount} consumables");
            }
            else if(spicyCount > timmyCount)
            {
                Console.WriteLine($"Spicy has eaten more than timmy, {spicyCount} consumables");
            }
            else if(spicyCount == timmyCount)
            {
                Console.WriteLine($"Spicy and Timmy have tied in their eating contest, both eating {spicyCount} consumables");
            }
        }
    }
}
