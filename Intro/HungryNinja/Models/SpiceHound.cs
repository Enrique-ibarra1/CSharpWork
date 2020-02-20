using System;
using System.Collections.Generic;
namespace HungryNinja.Models
{
    public class SpiceHound : Ninja
    {
        public override bool IsFull
        {
            get
            {
                if (calorieIntake > 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public override void Consume(IConsumable item)
        {
            if(IsFull == false)
            {
                calorieIntake += item.Calories;
                if(item.IsSpicy == true)
                {
                    calorieIntake -= 5;
                    Console.WriteLine("Spicy get spicy food");
                }
                ConsumableHistroy.Add(item);
                item.GetInfo();
            }
            else
            {
                Console.WriteLine("Please stop feeding me i cannot move oh god help");
            }
        }
    }
}