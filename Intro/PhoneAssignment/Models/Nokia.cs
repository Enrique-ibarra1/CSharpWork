using System;
namespace PhoneAssignment.Models
{
    public class Nokia : Phone, IRingable
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringtone) : 
        base(versionNumber, batteryPercentage, carrier, ringtone) {}
        public string Ring()
        {
            return $"...{Ringtone}...";
        }
        public string Unlock()
        {
            return $"Nokia {VersionNumber} unlocked with passcode"; 
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine($"Nokia {VersionNumber}");
            Console.WriteLine($"Battery percentage: {BatteryPercentage}");
            Console.WriteLine($"Carrier: {Carrier}");
            Console.WriteLine($"Ringtone: {Ringtone}");
            Console.WriteLine("*******************************");
        }
    }
}