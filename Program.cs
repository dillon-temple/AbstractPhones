using System;

namespace PhoneAbs
{
    class Program
    {
        static void Main(string[] args)
        {
            // public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone)

            Galaxy s8 = new Galaxy("s8", 100, "T-mobile", "BLEEP");
            Nokia brick = new Nokia("Brick", 95, "Verizon", "BOOM BAM");

            brick.DisplayInfo();
            brick.Ring();
            brick.Unlock();
            s8.DisplayInfo();
            s8.Ring();
            s8.Unlock();



        }
    }
}
