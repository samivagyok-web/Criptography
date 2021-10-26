using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    public class Decrypter
    {
        public string CryptedMessage { get; private set; }

        public Decrypter(string message)
        {
            CryptedMessage = message.ToUpper();
        }

        public string rotateByN(int key)
        {
            var decryptedMessage = "";

            foreach (var letter in CryptedMessage)
            {
                if ((letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z'))
                {
                    var character = ((letter + key - 65) % 26) + 65;
                    decryptedMessage += Convert.ToChar(character);
                }
                else
                {
                    decryptedMessage += letter;
                }
            }

            return decryptedMessage;
        }

        public string monoalphabeticSubstitution(string scrambledAlphabet)
        {
            string decryptedMessage = "";

            foreach (var letter in CryptedMessage)
            {
                if (letter == 32)
                    decryptedMessage += " ";
                else
                    decryptedMessage += Convert.ToChar(scrambledAlphabet.IndexOf(letter) + 65);
            }

            return decryptedMessage;
        }
    }
}
