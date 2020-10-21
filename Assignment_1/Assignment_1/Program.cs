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
            try
            {
                if (input.Contains("+"))            
                {
                    string[] splittedInput = input.Split('+');
                    foreach (var number in splittedInput)
                    {
                        int numberInt = int.Parse(number);
                        sum = sum + numberInt;
                    }
                    Console.WriteLine(sum);
                }
                else
                {
                    Console.WriteLine("Invalid Input, Numbers must be separated by a +");
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Entered value must be in numbers only");
            }
        }
    }
}
