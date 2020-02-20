namespace PhoneAssignment.Models
{
    public abstract class Phone
    {
        private string _versionNumber;
        private int _batteryPercentage;
        private string _carrier;
        private string _ringtone;
        public Phone(string versionNumber, int batteryPercentage, string carrier, string ringtone)
        {
            _versionNumber = versionNumber;
            _batteryPercentage = batteryPercentage;
            _carrier = carrier;
            _ringtone = ringtone;
        }

        public string VersionNumber
        {
            get{return _versionNumber;}
        }
        public int BatteryPercentage
        {
            get{return _batteryPercentage;}
        }
        public string Carrier
        {
            get{return _carrier;}
        }
        public string Ringtone
        {
            get{return _ringtone;}
        }


        public abstract void DisplayInfo();

        public interface IRingable
        {
        }
    }
}