using System;
using System.Collections.Generic;

namespace HungryNinja.Models
{
    public abstract class Ninja
    {
        protected int calorieIntake;
        public List<IConsumable> ConsumableHistroy;
        public Ninja()
        {
            calorieIntake = 0;
            ConsumableHistroy= new List<IConsumable>();
        }
        public abstract bool IsFull{get;}
        public abstract void Consume(IConsumable item);
    }
}