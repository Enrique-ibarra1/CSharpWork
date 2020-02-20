using System;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randInts = RandomArray();
            foreach(int randInt in randInts )
            {
                Console.WriteLine(randInt);//sum min and max get printed first 
                // then whole array is printed
            }
        }

        public static int[] RandomArray()
        {
            int[] numbers = new int[10];
            int min = numbers[0];
            int max = numbers[0];
            int sum = 0;
            
            Random randInt = new Random();
            for(int i = 0; i< 10; i++)
            {
                int newInt = randInt.Next(5,26);
                numbers[i] = newInt;
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
                if(numbers[i] > max)
                {
                    max = numbers[i];
                }
                sum += newInt;
            }
            Console.WriteLine($"sum: {sum}, min : {min}, max : {max}");
            return numbers;
        }
    }
}
