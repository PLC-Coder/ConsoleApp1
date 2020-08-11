using System;

namespace ConsoleApp1
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

               Console.WriteLine("Hello World! " + (num1 + num2));
            num3 = num1 + (int)num2;
            Console.WriteLine(num3);

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

        }
     }
}
