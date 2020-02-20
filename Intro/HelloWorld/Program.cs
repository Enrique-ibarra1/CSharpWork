using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string place = "Coding Dojo";
            string message = $"Hello {place}";
            Console.WriteLine(message);
            Console.WriteLine("My name is {0}, I am " + 28 + " years old", "Tim");
            Console.WriteLine($"My name is {0}, I am " + 28 + " years old", "Tim");
            //
            bool hungry = false;
            if(hungry)
            {
                Console.WriteLine("I'm Hungry");
            }
            else
            {
                Console.WriteLine("Not Hungry");
            }

            Random rand = new Random();
            for(int val = 0; val < 4; val++)
            {
            //Prints the next random value between 2 and 5, 4 times
            Console.WriteLine(rand.Next(2,5));
            }

            string[] myCars = { "Mazda Miata", "Ford Model T", "Dodge Challenger", "Nissan 300zx"}; //new string[] can be put before this
            for (int idx = 0; idx < myCars.Length; idx++)
            {
                Console.WriteLine($"I own a {myCars[idx]}");

            }

            List<string> bikes = new List<string>();
            bikes.Add("ninja");
            bikes.Add("Kawasaki");
            bikes.Add("Tricycle");
            bikes.Add("Harley Davidson");
            bikes.Add("Suzuki");
            bikes.Add("BMW");
            Console.WriteLine(bikes[2]);
            Console.WriteLine($"We currently know of {bikes.Count} different bikes.");
            Console.WriteLine("The current bikes we know of are: ");

            for(var idx = 0; idx < bikes.Count; idx++)
            {
                Console.WriteLine("-" + bikes[idx]);
            }

            bikes.Insert(0, "Honda");
            bikes.Remove("Tricycle");
            bikes.RemoveAt(5);
            Console.WriteLine("List of dope bike manufacturers: ");

            foreach (string company in bikes)
            {
                Console.WriteLine("-" + company);
            }

            Dictionary<string, string> profile = new Dictionary<string, string>();
            profile.Add("Name", "Timmy");
            profile.Add("LastName", "Timmyton");
            profile.Add("Language", "Python");
            profile.Add("Location", "Greece");
            Console.WriteLine("Instructor profile");
            Console.WriteLine("Name: " + profile["Name"] + " " + profile["LastName"]);
            Console.WriteLine("From :" + profile["Location"]);
            Console.WriteLine("Favorite Language: " + profile["Language"]);

            foreach (var entry in profile)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
