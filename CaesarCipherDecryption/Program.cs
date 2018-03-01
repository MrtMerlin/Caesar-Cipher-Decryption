/*
Student Name: Martin Lewis      Student Number: 014096

Program Synopsis: This is a program to read in a Caesar Cipher and solve the ciphers encryption. By taking the encrypted message
and running it through a while loop to determine the correct amount movements through the alphabet. Also the same system will be
used to encrypt a users input as well and display it to screen.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CaesarCipherDecryption // name space
{
    class Program // main program class this is where all of the program is run from.
    {
        static void Main(string[] args) // main of the program
        {
            #region declaringRegion
            // add TextFile class to the main for use.
            textFile text = new textFile();

            // test for text to be written to screen.
            //Console.WriteLine(text.caesarShiftEncodedText());

            // add Decipher class to the main for use 
            Decipher unencrypt = new Decipher();

            // text from textFile changed to a string theText, to read into caesar method.
            string theText = text.caesarShiftEncodedText();

            //test of writing program to screen before looping.
            // Console.WriteLine(unencrypt.Caesar(text.caesarShiftEncodedText(), 5));

            // int for user input.
            int userInput = 0;
            #endregion

            #region fullProgram

            #region menu
            // colour set for the title of the program.
            Console.ForegroundColor = ConsoleColor.Cyan;

            // title of the program, also author and student number in title.
            Console.WriteLine("************************************************************");
            Console.WriteLine("************************************************************");
            Console.WriteLine("Welcome to the Caesar Cipher Decipher and encryption program");
            Console.WriteLine("\t\tAuthor: Martin Lewis");
            Console.WriteLine("\t\tStudent Number: 014096");
            Console.WriteLine("************************************************************");
            Console.WriteLine("************************************************************");

            // colour reset
            Console.ResetColor();

            // statement for program to loop until the user wish to exit by selecting option 5.
            while (userInput != 5)
            {
                // try, catch any none of the selected inputs of the while loop, 
                try 
                {
                    // options menu
                    Console.WriteLine("Please select from the following options?");
                    Console.WriteLine("1. Show original text file to screen.");
                    Console.WriteLine("2. Show deciphered text paragraphs.");
                    Console.WriteLine("3. Show deciphered text paragraph.");
                    Console.WriteLine("4. Would you like to encrypt text");
                    Console.WriteLine("5. Exit Program");

                    // users input is converted to int and stored as user input.
                    userInput = Convert.ToInt32(Console.ReadLine());
                    #endregion

                    #region option1
                    // if option 1, display unencrypted code to viewer.
                    if (userInput == 1)
                        // code written to screen.
                        Console.WriteLine(text.caesarShiftEncodedText());
                    #endregion

                    #region option2
                    // if option 2, this will show all iterations of loop for decryptions of the code.
                    if (userInput == 2)
                    {
                        // for statement to loop through
                        for (int i = 0; i < 26; i++)
                        {
                            // test for limiting the amount of data passed through.
                            // Console.WriteLine(i + " " + unencrypt.Caesar(theText, i, 20));

                            // displaying the shift on the screen for the viewer.
                            Console.WriteLine("This is shift: {0}", i);

                            // to read through the hole textfile.
                            Console.WriteLine(unencrypt.Caesar(theText, i, theText.Length));
                        }// close of if statement.

                        // shows to screen, written text.
                        Console.WriteLine("This is shift: 5");

                        // shows to screen the specific unencrypted paragraph.
                        Console.WriteLine(unencrypt.Caesar(theText, 5, theText.Length));

                    }
                    #endregion

                    #region option3
                    // if option 3 select for displaying the deciphered code. 
                    if (userInput == 3)
                    {

                        // for statement to loop through
                        for (int i = 5; i == 5; i++)
                        {
                            // display the unincripted shift with the shift number. 
                            Console.WriteLine("This is shift " + i + " \n" + unencrypt.Caesar(theText, 5, theText.Length));
                        }// close of if statement.

                        //while (userInput != 'Y' || userInput != 'y' || userInput != 'N' || userInput != 'n')
                        //{
                        //    Console.WriteLine("Would you like to save this to file? Y/N");
                        //    userInput = Convert.ToChar(Console.ReadLine());

                                // while statement if the users input is not as required y or n will loop back to here.
                                while (userInput != 'Y' || userInput != 'y' || userInput != 'N' || userInput != 'n')
                                {
                                    // question if file required to be saved.
                                    Console.WriteLine("Would you like to save this to file? Y/N");

                                    // users input converted and saved.
                                    userInput = Convert.ToChar(Console.ReadLine());
                                    
                                    // if userInput is yes, file is saved. 
                                    if (userInput == 'Y' || userInput == 'y')
                                    {
                                        // declare string variables for storage for use.
                                        string original = "";
                                        string writeOut = "";
                                        
                                        // convert long path to short path for use with ceasarshift.
                                        original = text.caesarShiftEncodedText();

                                        // convert long path to short path for use with ceasarshift.
                                        writeOut = unencrypt.Caesar(theText, 5, theText.Length);

                                // try to catch any erreonous activity when saving the file to HTML.

                                        // file is written to filepath, using string contents which include the methods original and writeOut. This is written to html doc,
                                        // when written there are styling applied to the page as well.
                                        File.WriteAllText("../../../ReadOutFiles/Decrypted.html", "<!DOCTYPE html><html><header><style>.original{width: 900px; background-color: #cccccc;"
                                            + "margin-bottom: 20px; margin-left: auto; margin-right: auto;} \n .writeOut{width: 900px; background-color: #cccccc; word-wrap: break-word; "
                                            + "margin-left: auto; margin-right: auto;} h1{text-align: center;}</style></header><body><h1>Encrypted and Deciphered Text"
                                            + "</h1><div class=\"original\">" + original + "</div>\n<div class=\"writeOut\">" + writeOut + "</div></body></html>");

                                        // written to screen to confirm to user task has been performed.
                                        Console.WriteLine("The file has now been written. Please see folder ReadOutFiles in the program directory. Thank you.");
                                        
                                        // breaks out of loop.
                                        break;
                                    }
                                        // selection if the user selects no.
                                        if (userInput == 'N' || userInput == 'n')
                                        {
                                                // written to screen.
                                                Console.WriteLine("Thank you for viewing, Please press a key to exit to menu.");

                                                // user input saved for exit to be carried out.
                                                userInput = Convert.ToChar(Console.ReadLine());
                                                
                                                // break out of loop.
                                                break;
                                        }
                                        // statement to explain that the user has not entered the correct input.
                                        if (userInput != 'Y' || userInput != 'y' || userInput != 'N' || userInput != 'n')
                                        {
                                            // changes background colour.
                                            Console.BackgroundColor = ConsoleColor.Red;

                                            // writes to screen to advise of incorrect mistake, also with background. 
                                            Console.WriteLine("That was an incorrect input. Please use Y/y or N/n for entry.");
                                
                                            //color background reset. 
                                            Console.ResetColor();
                                        }
                                    }
                            }

                    #endregion

                    #region option4
                    // if user selects option 4 for encrypting there own input.
                    if (userInput == 4)
                        {
                            // calling the encrypt class, methods within this class can then be used.
                            EncryptInput encrypt = new EncryptInput();
                            
                            // string input variable for use
                            string inputStr = null;

                            string userResult = null;

                            // int input variable for use
                            int inputInt = 0;

                                // user requested to enter string they wish to encrypt.
                                Console.WriteLine("Please enter the text you wish to Encrypt?");

                                // user input is converted and saved in the inputStr variable.
                                inputStr = Convert.ToString(Console.ReadLine());

                                // user is requested to enter the number of times they wish to move the shift when encrypting. 
                                Console.WriteLine("Please enter the number of shifts You would like to perform?");

                                // users input saved to inputInt variable.
                                inputInt = Convert.ToInt32(Console.ReadLine());

                                userResult = encrypt.encryptCaesar(inputStr.ToUpper(), inputInt);
                                // encrypted text written to screen.
                                Console.WriteLine("Your text encoded is {0}", userResult);

                                // while statement if the users input is not as required y or n will loop back to here.
                                while (userInput != 'Y' || userInput != 'y' || userInput != 'N' || userInput != 'n')
                                {
                                    // question if file required to be saved.
                                    Console.WriteLine("Would you like to save this to file? Y/N");

                                    // users input converted and saved.
                                    userInput = Convert.ToChar(Console.ReadLine());

                                    // if userInput is yes, file is saved. 
                                    if (userInput == 'Y' || userInput == 'y')
                                    {
                                        // file is written to filepath, using string contents which include the methods original and writeOut. This is written to html doc,
                                        // when written there are styling applied to the page as well.
                                        File.WriteAllText("../../../ReadOutFiles/Encrypted.html", "<!DOCTYPE html><html><header><style>.original{width: 900px; background-color: #cccccc;"
                                            + "margin-bottom: 20px; margin-left: auto; margin-right: auto;} \n .writeOut{width: 900px; background-color: #cccccc; word-wrap: break-word; "
                                            + "margin-left: auto; margin-right: auto;} h1{text-align: center;}</style></header><body><h1>User Input and Encrypted Text"
                                            + "</h1><div class=\"original\">" + inputStr + "</div>\n<div class=\"writeOut\">" + userResult + "</div></body></html>");

                                        // written to screen to confirm to user task has been performed.
                                        Console.WriteLine("The file has now been written. Please see folder ReadOutFiles in the program directory. Thank you.");

                                        // breaks out of loop.
                                        break;
                                    }
                                    // selection if the user selects no.
                                    if (userInput == 'N' || userInput == 'n')
                                    {
                                        // written to screen.
                                        Console.WriteLine("Thank you for viewing, Please press a key to exit to menu.");

                                        // user input saved for exit to be carried out.
                                        userInput = Convert.ToChar(Console.ReadLine());

                                        // break out of loop.
                                        break;
                                    }
                                    // statement to explain that the user has not entered the correct input.
                                    if (userInput != 'Y' || userInput != 'y' || userInput != 'N' || userInput != 'n')
                                    {
                                        // changes background colour.
                                        Console.BackgroundColor = ConsoleColor.Red;

                                        // writes to screen to advise of incorrect mistake, also with background. 
                                        Console.WriteLine("That was an incorrect input. Please use Y/y or N/n for entry.");

                                        //color background reset. 
                                        Console.ResetColor();
                                    }
                                }
                            }
                    #endregion


                    #region option5

                    // option 5 is selected, exit application.
                    if (userInput == 5)
                            
                            // calls enviroment.exit.
                            System.Environment.Exit(0);
                    
                    }
                #endregion

                //catch informs the user they have input an incorrect character and to try again.
                catch (FormatException)
                {
                    // colour of the text changed to red.
                    Console.ForegroundColor = ConsoleColor.Red;

                    // written to screen to advise incorrect value used.
                    Console.WriteLine("Error you have not entered a numeric value, please try again!");

                    // colour reset for the following while loop.
                    Console.ResetColor();
                }
            }

            Console.ReadLine(); // pause text on screen

        }// close of main
        #endregion
    } // close of class.
}
