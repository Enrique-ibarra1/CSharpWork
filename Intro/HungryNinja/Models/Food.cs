namespace HungryNinja.Models
{
    public class Food : IConsumable
    {
        // public string Name;
        // public int Calories;
        // public bool IsSpicy;
        // public bool IsSweet;
        // public Food(string foodName, int cal, bool spicy, bool sweet)
        // {
        //     Name = foodName;
        //     Calories = cal;
        //     IsSpicy = spicy;
        //     IsSweet = sweet;
        // }
        public string Name {get; set;}
        public int Calories {get; set;}
        public bool IsSpicy {get; set;}
        public bool IsSweet {get; set;}

        public string GetInfo()
        {
            return $"{Name} (Food).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }
        public Food(string name, int calories, bool spicy, bool sweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = spicy;
            IsSweet = sweet;
        }
    }
}