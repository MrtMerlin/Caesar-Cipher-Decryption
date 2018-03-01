/*
 
This is the File class, the file is opened within this class and method and then passed to the method calling it.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CaesarCipherDecryption // name space
{
    class textFile // class name

    { // start of class

        public string caesarShiftEncodedText() // method for calling and displaying the encrypted message in the main program.
        { // start of method
            
            // call file from file location            
            string file = @"caesarShiftEncodedText.txt";

            // opens text file, reads the file and then closes the file.
            string text = File.ReadAllText(file);

            // return text from file to method calling for text.
            return text;

        }// end of method
       
    } // end of class
}
