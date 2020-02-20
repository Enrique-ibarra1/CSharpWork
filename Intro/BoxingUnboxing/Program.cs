using System;
using System.Collections.Generic;


namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> dataList = new List<object>();
            int seven = 7;
            dataList.Add(seven);
            dataList.Add(28);
            dataList.Add(-1);
            dataList.Add(true);
            dataList.Add("chair");

            int sum = 0;
            for(int i = 0; i<dataList.Count; i++)
            {
                if(dataList[i] is int)
                {
                    sum += (int)dataList[i];
                }
                //Loop through the list and print all values
                //is this all the comment above is asking?
                Console.WriteLine(dataList[i]);
            }
            Console.WriteLine(sum);

        }
    }
}
