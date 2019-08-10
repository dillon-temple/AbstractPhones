using System;

namespace PhoneAbs
{
    public class Nokia : Phone, IRingable
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone)
            : base(versionNumber, batteryPercentage, carrier, ringTone) {

             }
        public string Ring()
        {
            Console.WriteLine(this.RingTone);
            return this.RingTone;
        }

        public string Unlock()
        {
            Console.WriteLine("Nokia Unlocked");
            return "Nokia Unlocked";
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Version: {this.VersionNumber}\n Battery: {this.BatteryPercentage}\n Carrier: {this.Carrier}\n Ring Tone: {this.RingTone}");
        }
    }
}
