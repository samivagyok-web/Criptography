using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Caesar
{
    public class Crypter
    {
        public string Message { get; set; }

        public Crypter(string message)
        {
            Message = message.ToUpper();
        }

        public string rotateByN(int key)
        {
            var cryptedMessage = "";

            foreach (var letter in Message)
            {
                if ((letter >= 'a' && letter <= 'z') || (letter >= 'A' && letter <= 'Z'))
                {
                    var character = ((letter + key - 65) % 26) + 65;
                    cryptedMessage += Convert.ToChar(character);
                }
                else
                {
                    cryptedMessage += letter;
                }

            }

            return cryptedMessage;
        }

        public string monoalphabeticSubstitution(string scrambledAlphabet)
        {
            Regex replaceNonLetters = new Regex("[^a-zA-Z ]");
            string message = replaceNonLetters.Replace(Message, "").ToUpper();
            
            string cryptedMessage = "";

            foreach (var item in message)
            {
                if (item == 32)
                    cryptedMessage += " ";
                else
                    cryptedMessage += scrambledAlphabet[item - 65];
            }

            return cryptedMessage;
        }
    }
}
