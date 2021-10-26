using System;

namespace Caesar
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CAESAR_KEY = 3;
            const int ROT13_KEY = 13;

            Decrypter decrypter = new("SIAA ZQ LKBA VA ZOA RFPBLUAOAR");
            Crypter crypter = new("flee at once. we are discovered!");
        }
    }
}
