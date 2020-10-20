using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter a series of numbers, separated by a +");
            string input = Console.ReadLine();
             if(input.Contains("+"))
             { 
                  string[] splittedInput = input.Split('+');
                  foreach (var number in splittedInput)
                  {
                      int numberInt = Int32.Parse(number);
                      sum = sum + numberInt;
                  }
                  Console.WriteLine(sum);
             }
            else
            {
                Console.WriteLine("Invalid Input, Numbers must be separated by a +");
            }
        }
    }
}
