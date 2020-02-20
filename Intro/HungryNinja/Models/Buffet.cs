using System;
using System.Collections.Generic;

namespace HungryNinja.Models
{
    public class Buffet
    {
        public List<IConsumable> Menu;

        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Pizza", 500, false, false),
                new Food("Curry", 400, true, false),
                new Food("Chili", 350, true, false),
                new Food("Fish", 250, false, false),
                new Food("Taco", 300, true, false),
                new Food("Cake", 600, false, true),
                new Food("Pasta", 400, false, false),
                new Drink("Bepsi", 250),
                new Drink("Dr pepper", 300),
                new Drink("Cake Juice", 350),
            };
        }
        public IConsumable Serve()
        {
            Random rand = new Random();
            IConsumable selected = Menu[rand.Next(0, Menu.Count)];
            return selected;
        }
    }
}