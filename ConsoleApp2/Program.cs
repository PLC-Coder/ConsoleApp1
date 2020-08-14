using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = -2;
            uint num2 = 10;
            int num3;
            char[] charArr = new char[10];
            char loopChar = 'A';
            int numString = Convert.ToInt32("45");
            int num11 = 0;
            int num12 = 0;

            Console.WriteLine("32" + "16");
            Console.WriteLine("32" + "16" + numString);
            Console.WriteLine(Convert.ToInt32("32") + numString);

            Debug.WriteLine("Hello World From Debug!");
            Console.WriteLine("Hello World! " + (num1 + num2));
            num3 = num1 + (int)num2;
            Console.WriteLine(num3);

            string stripString = "ABC123DEF";
            string strippedString;

            strippedString = stripString.Substring(3, 3);

            Console.WriteLine("StrippedString is: " + strippedString);
            Console.WriteLine("strippedString + 45: " + (Convert.ToInt32(strippedString) + 45));
            Console.WriteLine(10.15);

            string[] friends;
            friends = new string[5];

            string[] ladies = { "Jamie", "Kelly", "May", "Rebecca", "Victoria" };

            for (int i = 0; i < charArr.Length; i++)
            {
                charArr[i] = loopChar;
                loopChar++;
            }

            foreach (var item in charArr)
            {
                Console.WriteLine(item);
            }

            //working with datatypes and variables for Math
            int numInt; // Integer
            float numFlt; // Least precise
            double numDbl; // More precise
            decimal numDec; // Most precise

            numInt = 1;
            numFlt = 1;
            numDbl = 2;
            numDec = 3;

            Console.WriteLine("numInt: " + numInt);
            Console.WriteLine("numFlt: " + numFlt);
            Console.WriteLine("numDbl: " + numDbl);
            Console.WriteLine("numDec: " + numDec);
            Console.WriteLine();

            numInt = 1;
            numFlt = 1.0F;
            numDbl = 2.0;
            numDec = 3.0M;

            Console.WriteLine("numInt: " + numInt);
            Console.WriteLine("numFlt: " + numFlt);
            Console.WriteLine("numDbl: " + numDbl);
            Console.WriteLine("numDec: " + numDec);
            Console.WriteLine();

            numInt = 1;
            numFlt = 1.2F;
            numDbl = 2.2;
            numDec = 3.2M;

            Console.WriteLine("numInt: " + numInt);
            Console.WriteLine("numFlt: " + numFlt);
            Console.WriteLine("numDbl: " + numDbl);
            Console.WriteLine("numDec: " + numDec);
            Console.WriteLine();

            // Try some addition math with the numeric datatypes
            Console.WriteLine("numInt + numFlt: " + (numInt + numFlt));
            Console.WriteLine("numInt + numDbl: " + (numInt + numDbl));
            Console.WriteLine("numInt + numDec: " + (numInt + numDec));
            Console.WriteLine();

            Console.WriteLine("numFlt + numDbl: " + (numFlt + numDbl));
            Console.WriteLine("numFlt + (float)numDec: " + (numFlt + (float)numDec));
            Console.WriteLine("(decimal)numFlt + numDec: " + ((decimal)numFlt + numDec));

            Console.WriteLine();

            // Array of Station completion status.  For Readability purposes, index 0 is not used in the program
            Station[] Sta = new Station[10];

            // Some boolean logic - such as working with PLC's
            // First will initialize a custom struct for station variables
            // Please note that Station 0 is not used, but is still initialized
            for (int i = 0; i < Sta.Length; i++)
            {
                Sta[i].CmpltFlag = false;
                Sta[i].PartPresent = false;
                Sta[i].PartFailed = true;
                Sta[i].Homed = false;
                Sta[i].OpInProgress = false;
                Sta[i].StaName = "Station " + i;
                Sta[i].PrtType = PartType.ELECTRICAL;
                Sta[i].PrtVersion = PartVersion.BOTH;

            }

            // Display the current status of each station from 1 to 4
            // Use a half second delay between results to give the reader enough time to view the information
            for (int i = 0; i < Sta.Length; i++)
            {
                if (i <= 0 || i >= 5)
                    continue;

                Console.WriteLine(Sta[i].StaName + " Complete Flag: " + Sta[i].CmpltFlag);
                // System.Threading.Thread.Sleep(500);
                Console.WriteLine(Sta[i].StaName + " Part Present: " + Sta[i].PartPresent);
                // System.Threading.Thread.Sleep(500);
                Console.WriteLine(Sta[i].StaName + " Part Type: " + Sta[i].PrtType);
                // System.Threading.Thread.Sleep(500);
                Console.WriteLine(Sta[i].StaName + " Part Version: " + Sta[i].PrtVersion);
                // System.Threading.Thread.Sleep(500);
                Console.WriteLine();
            }

            // Conditions to Start Station
            if (Sta[1].PartPresent && Sta[1].Homed)
                Sta[1].OpInProgress = true;
            Sta[1].CmpltFlag = false;

            // Station Complete
            if (Sta[1].CmpltFlag && Sta[1].Homed)
                Sta[1].OpInProgress = false;

            //Using an ENUM in a switch statement
            switch (Sta[1].PrtVersion)
            {
                case PartVersion.LH:
                    Console.WriteLine("LH");
                    break;
                case PartVersion.RH:
                    Console.WriteLine("RH");
                    break;
                case PartVersion.BOTH:
                    Console.WriteLine("BOTH");
                    break;
                default:
                    Console.WriteLine("NO PART VERSION");
                    break;
            }

            //Some Math Functions
            Console.WriteLine("The greater number of 10 and 15 is: " + Math.Max(10, 15));
            Console.WriteLine("The square root of 144 is: " + Math.Sqrt(144));
            Console.WriteLine("2 raised to the Power of 3 is: " + Math.Pow(2, 3));

            //Working with passing arguments by reference to methods and functions
            int hoursWorked = 0;
            int methodStatus;
            methodStatus = PrintAgeName(30, "John", ref hoursWorked);
            methodStatus = PrintAgeName(30, "John", ref hoursWorked);
            methodStatus = PrintAgeName(30, "John", ref hoursWorked);
            Console.WriteLine("Method Status of PrintAgeName is: " + methodStatus);
            Console.WriteLine();

            // GUESSING GAME ////////////////////////////////////////////////////////////
            string secretWord = "Great";
            string guess = "";
            int numGuesses = 5;
            bool outOfGuesses = false;

            while (guess != secretWord && numGuesses > 0)
            {
                Console.WriteLine("Let's play a guessing game.");
                Console.WriteLine(numGuesses + " tries are remaining...");
                Console.Write("Enter a word: ");
                guess = Console.ReadLine();
                if (guess != secretWord)
                {
                    Console.WriteLine("Incorrect word, please try again.");
                }
                numGuesses--;
                Console.WriteLine();
                if (numGuesses == 0) { outOfGuesses = true; }
            }

            if (!outOfGuesses) { Console.WriteLine("Congratulations, you win!"); }
            else { Console.WriteLine("You are not very good at guessing.  You loose!"); }
            // END GUESSING GAME /////////////////////////////////////////////////////////////////////////////

            Console.WriteLine(numGuesses++);
            Console.WriteLine(numGuesses);

            Console.WriteLine(GetPow(2, 3));

            // Some multidimensional arrays
            int[,,,,,,,] crazy8DimArray = new int[5, 5, 5, 5, 5, 5, 5, 5]; // 8 Dimension Array!

            crazy8DimArray[0, 1, 4, 3, 3, 1, 0, 1] = 12;

            Console.WriteLine("crazy8DimArray[0,0,0,0,0,0,0,0] is: " + crazy8DimArray[0, 0, 0, 0, 0, 0, 0, 0]);
            Console.WriteLine("crazy8DimArray[0,1,4,3,3,1,0,1] is: " + crazy8DimArray[0, 1, 4, 3, 3, 1, 0, 1]);

            // 2 Dimensional multidimensional arrays (2,2)
            int[,] crazy2DimArray = { { 1, 2 }, { 3, 4 } };

            // 3 Dimensional multidimensional arrays {3,3,3) (Count the row first, then the column, then the final column)
            int[,,] crazy3dimArray = { {{ 1, 2, 3}, { 4, 5, 6}, { 7, 8, 9 } },
                                        { {1, 1, 1 }, {2, 2, 2 }, {3, 3, 3 } },
                                        { {1, 1, 1 }, {2, 2, 2 }, {3, 3, 3 } } };

            Console.WriteLine(crazy3dimArray[0, 1, 2]); // Should be 6

            //Lets move on to 4-Dim Array! {2,2,2,2} (Count the row first, then the next row, then the column, then the final column)
            int[,,,] crazy4DimArray = { {{{ 1, 2 }, { 3, 4 } }, //First set
                                        {{5, 6 }, {7, 8 } } },

                                        {{{ 9, 10 }, { 11, 12 } }, //Second set
                                        {{13, 14 }, {15, 16 } } } };

            Console.WriteLine(crazy4DimArray[1, 0, 1, 1]); // Should be 12
            Console.WriteLine();

            //Is your MIND BLOWN YET?  Mine is A little bit, but not really...
            //Lets try for the 5-Dim Array!!!
            //Psych!  I'm too tired and lazy to do this right now... Moving on to other subjects...


            // Exception Handling
            try
            {
                Console.Write("Enter a number: ");
                num11 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                num12 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine(num11 + " / " + num12 + " is: " + (num11 / num12));
                Console.WriteLine();
            }
            
            //catch (System.DivideByZeroException ex)
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception 1: " + ex.Message);
                Console.WriteLine("num11 is: " + num11);
                Console.WriteLine("num12 is: " + num12);
            }
           
            //catch (System.FormatException ex)
            catch (System.FormatException ex)
            {
                Console.WriteLine("Exception 2: " + ex.Message);
                Console.WriteLine("num11 is: " + num11);
                Console.WriteLine("num12 is: " + num12);
            }
            
            //catch (System.OverflowException ex)
            catch (OverflowException ex)
            {
                Console.WriteLine("Exception 3: " + ex.Message);
                Console.WriteLine("num11 is: " + num11);
                Console.WriteLine("num12 is: " + num12);
            }

            finally // finally is optional
            {
                // Print values of num11 and num12
                Console.WriteLine("num11 is: " + num11);
                Console.WriteLine("num12 is: " + num12);
                Console.WriteLine();
                
                // rest num11 and num12 to 0
                num11 = 0;
                num12 = 0;

                // Verify set back to 0
                Console.WriteLine("After resetting, num11 is: " + num11);
                Console.WriteLine("After resetting, num12 is: " + num12);
                Console.WriteLine();
            }

            Console.WriteLine("Program Continues Past Division!");

        }

        enum PartType // PartTypes
        {
            ELECTRICAL,
            ELECTRONIC,
            MECHANICAL
        }

        enum PartVersion // PartVersions
        {
            LH,
            RH,
            BOTH
        }

        // STATION STATUS
        /// <summary>
        /// Struct of Station Status Flags and Part Status Flags.
        /// </summary>
        /// <returns>
        /// None.
        /// </returns>
        struct Station
        {
            public bool CmpltFlag;
            public bool PartPresent;
            public bool PartFailed;
            public bool Homed;
            public bool OpInProgress;

            public string StaName;
            public string OperationDescription;

            public PartType PrtType;
            public PartVersion PrtVersion;
        }
        /// <summary>
        /// Takes the age and name of a person as arguments and prints out to the console
        /// </summary>
        /// <param name="age"></param>
        /// <param name="name"></param>
        /// <param name="hoursWorked"></param>
        /// <returns>int Success of Function = 0</returns>
        static int PrintAgeName(int age, string name, ref int hoursWorked)
        {
            Console.WriteLine("Your age is: " + age);
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("Hours Worked: " + (hoursWorked += 40));
            return 0;
        }

        static double GetPow(double baseNum, double powNum)
        {
            return Math.Pow(baseNum, powNum);
        }
    }
    class SafetyBlock
    {

    }
}
