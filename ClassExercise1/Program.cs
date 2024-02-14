/*
 * INFO 350 - Class Exercise 1
 * 
 * 
 */


using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString;

            Console.WriteLine("Type in a birth year: ");

            // reads in a string from the console
            inputString = Console.ReadLine();

            // checks that we got a string back instead of a null
            // note we have not covered null yet
            if (inputString == null)
            {
                Console.WriteLine("Incorrect input, exiting");
                return;
            }


            // how to get the current year
            int currentYear = DateTime.Now.Year;


            /*
             * note that below, the " is escaped as \" such that the compiler
             * doesn't mistake it for the end of the string
             */
            Console.WriteLine("Your age is " + currentYear );
        }
    }
}