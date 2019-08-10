using System;

namespace PhoneAbs
{
    public class Galaxy : Phone, IRingable
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone)
            : base(versionNumber, batteryPercentage, carrier, ringTone) { }
        public string Ring()
        {
            Console.WriteLine(this.RingTone);
            return this.RingTone;
        }

        public string Unlock()
        {
            Console.WriteLine("Galaxy Unlocked");
            return "Galaxy Unlocked";
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Version: {this.VersionNumber}\n Battery: {this.BatteryPercentage}\n Carrier: {this.Carrier}\n Ring Tone: {this.RingTone}");

        }
    }
}