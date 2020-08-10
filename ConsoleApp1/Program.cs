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
               Console.WriteLine("Hello World! " + (num1 + num2));
            num3 = num1 + (int)num2;
            Console.WriteLine(num3);
          }
     }
}
