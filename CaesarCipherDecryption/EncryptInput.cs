/*

This is the encryption class, this holds the method to encrypt the user input.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherDecryption // namespace of the overall program.
{
    class EncryptInput // opening class encrypt 
    {
        // method encryptCaesar to encrypt input, has to variables passed to it value and movement
        public string encryptCaesar(string value, int movement) 
        {
            // converts input value into char
            char[] enc = value.ToCharArray();

            // string for result to be passed back to main.
            string encrypted = "";

            // for loop, loop through each char within the input file.
            for (int i = 0; i < value.Length; i++)
            {
                // each of chars within enc[i] renamed as letter
                char letter = enc[i];

                // combining letter and movement with +, controls the direction 
                // of shift within the decipher method.
                letter = (char)(letter + movement);

                // if letter = A it is moved 26 spaces to Z
                if (letter < 'A')
                    letter = (char)(letter + 26);

                // if letter = Z it is moved 26 spaces to A
                if (letter > 'Z')
                    letter = (char)(letter - 26);

                // if statement to check letter is within the alphabet, if anyother character
                // it is removed.
                if (letter >= 'A' && letter <= 'Z')
                {
                    // Store the shift in letters
                    encrypted += letter;
                }
            }

            // return encrypted to main program.
            return encrypted;
        }
    } // close encrypt.
}
