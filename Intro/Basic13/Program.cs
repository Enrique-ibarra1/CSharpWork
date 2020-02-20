using System;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            int[] nums = {3,-4,5,6,-7,8};
            // LoopArray(nums);
            // int max = FindMax(nums);
            // Console.WriteLine(max);
            // GetAvg(nums);
            // MinMaxAvg(nums);
            // int[] odds = OddArray();
            // Console.WriteLine(odds);
            // int greaters = GreaterThanY(nums, 2);
            // Console.WriteLine(greaters);
            // SquareArrayValues(nums);
            // EliminateNegatives(nums);
            // ShiftValues(nums);
            NumToString(nums);// debug at line 190
        }
        public static void PrintNumbers()
        {
            //Var is an "anonymouse" data type; mostly used on for loops. it can be anthing.. maybe?
            for (var i =1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }

        //
        public static void PrintOdds()
        {
            for (int i = 1; i <= 255; i++)
            {
                if(i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void PrintSum()
        {
            int sum = 0;
            for(int i = 0; i <= 255; i++){
                sum += i;
                Console.WriteLine($"New Number {i}, Sum: {sum}");
            }
        }

        public static void LoopArray(int[] numbers)
        {
            foreach( int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public static int FindMax(int[] numbers) 
        // here after static we are defining that this function returns an Integer
        {
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if(num > max)
                {
                    max = num;
                }
            }
            return max; //returning the integer here.
        }

        public static void GetAvg(int[] numbers)
        {
            int sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
            }
            double avg = (double)sum/ (double)numbers.Length;
            Console.WriteLine(avg);
        }

        public static int[] OddArray()
        {
            // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255.
            int count = 0;
            for (int i = 1; i <= 255; i++)
            {
                if(i%2 == 1)
                {
                    count ++;
                }
            }
            int[] odds = new int[count];
            int iterator = 0;
            for (int i = 1; i <= 255; i++)
            {
                if(i%2 == 1)
                {
                    odds[iterator] = i;
                    iterator ++;
                }
            }
            return odds;
        }   

        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            for(int i =0; i < numbers.Length; i++)
            {
                if(numbers[i] > y)
                {
                    count ++;
                }
            }
            return count;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            for( int i =0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers [i];
            }
        }//checked debugger everything works :)

        public static void EliminateNegatives(int[] numbers)
        {
            for( int i =0; i < numbers.Length; i++)
            {
                if(numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        public static void MinMaxAvg(int[] numbers)
        {
            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                else if(numbers[i] < min)
                {
                    min = numbers[i];
                }
                sum += numbers[i];
            }
            Console.WriteLine($"Max: {max}, min: {min}, sum: {sum}, average: {sum/numbers.Length}");
        }

        public static void ShiftValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length-1; i++)
            {
                numbers[i] = numbers[i+1];
            }
            numbers[numbers.Length-1] = 0;
        }

        public static object[] NumToString(int[] numbers)
        {
            object[] output = new object[numbers.Length];
            for (int i =0; i <numbers.Length; i++)
            {
                if(numbers[i] < 0)
                {
                    output[i] = "Dojo";
                }
                else
                {
                    output[i] = numbers[i];
                }
            }
            return output;
        }



    }
}
