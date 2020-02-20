using System;

namespace PhoneAssignment.Models
{
    public class Galaxy : Phone, IRingable
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringtone) : 
        base(versionNumber, batteryPercentage, carrier, ringtone)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine($"Galaxy {VersionNumber}");
            Console.WriteLine($"Battery percentage: {BatteryPercentage}");
            Console.WriteLine($"Carrier: {Carrier}");
            Console.WriteLine($"Ringtone: {Ringtone}");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$");
        }

        public string Ring()
        {
            return $"...{Ringtone}...";
        }

        public string Unlock()
        {
            return $"Galaxy {VersionNumber} unlocked with Face unlock";
        }
    }
}