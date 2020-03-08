using System;

namespace Lab7_4_Thomas_Morris
{
    class Program
    {
        static void Main(string[] args)
        {
            DatingProfile dave = new DatingProfile("Dave", "Jones", 36, "Male");
            dave.WriteBio("Husky, strong, and a perfect gentleman.");

            DatingProfile abigal = new DatingProfile("Abigal", "Jenkins", 29, "Female");
            abigal.WriteBio("Shy and hoping to find a nice guy.");

            dave.SendMessage("Hi Abigal", "Would you like to go out to dinner with me?", abigal);

            abigal.ReadMessage();
        }
    }
}
