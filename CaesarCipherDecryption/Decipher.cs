/*

This is the decipher class, this holds the methods to unencrypt the files.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipherDecryption // name space
{
    class Decipher // Decipher class opening.
    {
        // method for caesar, has inputs of string, int and int.
        public string Caesar(string value, int movement, int length) 
        {
            // converts input value into char
            char[] enc = value.ToCharArray();

            // string for result to be passed back to main.
            string result = ""; 
            
            // for loop, loop through each char within the input file.
            for (int i = 0; i < length; i++)
            {
                // each of chars within enc[i] renamed as letter
                char letter = enc[i];

                // combining letter and movement with -, controls the direction 
                // of shift within the decipher method.
                letter = (char)(letter - movement);

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
                    result += letter;
                }  
            } // closed for loop.

            // return result to main program.
            return result;
        }
    }// class close
}
