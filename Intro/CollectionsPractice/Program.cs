using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {0,1,2,3,5,6,7,8,9}; //Create an array to hold integer values 0 through 9
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};//Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            //Create an array of length 10 that alternates between true and false values, starting with true
            bool[] booleans = new bool[10] {true, false, true, false, true, false, true, false, true, false};
            //Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>() {"Chocolate", "Vanilla", "Nutella", "Coconut", "Pistachio", "Cookie dough"}; 
            Console.WriteLine(flavors.Count);//Output the length of this list after building it
            Console.WriteLine($"Removing flavor : {flavors[flavors.Count-1]}");//Output the last flavor in the list, then remove this value
            flavors.RemoveAt(flavors.Count-1);//remove 
            Console.WriteLine(flavors.Count);//print new length

            Dictionary<string, string> UserInfo = new Dictionary<string, string>();
            for (var i =0; i < names.Length; i++)
            {
                Random rand = new Random();
                string flavor = flavors[rand.Next(0,flavors.Count)];
                UserInfo.Add($"{names[i]}", $"{flavor}");
            }
            foreach (var person in UserInfo)
            {
                Console.WriteLine(person.Key + " - " + person.Value);
            }
        }
    }
}
