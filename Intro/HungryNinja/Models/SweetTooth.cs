using System;
using System.Collections.Generic;
namespace HungryNinja.Models
{
    public class SweetTooth : Ninja
    {
        public override bool IsFull
        {
            get
            {
                if (calorieIntake > 1500)
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
                if(item.IsSweet == true)
                {
                    calorieIntake += 10;
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