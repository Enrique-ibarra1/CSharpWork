using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // // 1-255
            for(int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }

            // //1-100, divisble by 3 or 5, not both
            for(int j = 1; j<= 100; j++ )
            {
                if(j%3 == 0 && j%5 == 0)
                {
                    continue;
                }
                else if (j%3 == 0)
                {
                    Console.WriteLine(j);
                }
                else if (j%5 == 0)
                {
                    Console.WriteLine(j);
                }
            }

            // //divisible by 3 or 5, or 3 and 5
            for(int n = 1; n<= 100; n++ )
            {
                if (n%3 ==0 && n%5 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                }
                else if(n%3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (n%5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    continue;
                }
            }


            //while loop
            int x = 1;
            while (x <=100)
            {
                if (x%3 == 0 && x % 5==0)
                {
                    x++;
                    continue;
                }
                else if(x%3 ==0)
                {
                    Console.WriteLine(x);
                    x++;
                }
                else if(x%5 == 0)
                {
                    Console.WriteLine(x);
                    x++;
                }
                else
                {
                    x++;
                    continue;
                }
            }
        }
    }
}
