using System;
using System.Collections.Generic;
using PhoneAssignment.Models;

namespace PhoneAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("s8", 100, "Verizon", "AAAAHHHHHHHH");
            Nokia elevenhundred = new Nokia("1100", 90, "T-mobile", "Your brick is ringing.");
            s8.DisplayInfo();
            Console.WriteLine(s8.Ring());
            Console.WriteLine(s8.Unlock());

            elevenhundred.DisplayInfo();
            Console.WriteLine(elevenhundred.Ring());
            Console.WriteLine(elevenhundred.Unlock());
        }
    }
}
