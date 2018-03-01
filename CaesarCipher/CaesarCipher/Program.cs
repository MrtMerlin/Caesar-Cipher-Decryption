using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = TestCase;

            Console.WriteLine(str);
            str = Encrypt(str, 5);
            Console.WriteLine("Encrypted: {0}", str);
            str = Decrypt(str, 5);
            Console.WriteLine("Decrypted: {0}", str);
            Console.ReadKey();

        }

        static char Encrypt(char ch, int code)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }
            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)(((ch + code - offset) % 26) + offset);
        }


        static string Encrypt(string input, int code)
        {
            return new string(input.ToCharArray().Select(ch => Encrypt(ch, code)).ToArray());
        }

        static string Decrypt(string input, int code)
        {
            return Encrypt(input, 26 - code);
        }

        const string TestCase = "Pack my box with five dozen liquor jugs.";
    }
}
