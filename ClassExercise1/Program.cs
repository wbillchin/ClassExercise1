/*
 * INFO 350 - Class Exercise 1
 * 
 * 
 */


using System;
using System.Diagnostics;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string inputString;
            const int maxBirthYearsCount = 10;
            int[] birthYears = new int[maxBirthYearsCount];
            int[] age = new int[maxBirthYearsCount];
            int birthYearIndex = 0;
            bool finishedInputs = false;

            while( finishedInputs == false )
            {
                Console.WriteLine("Type in a birth year or \"done\" to finish: ");
                // reads in a string from the console
                inputString = Console.ReadLine();

                // checks that we got a string back instead of a null
                // note we have not covered null yet
                if (inputString == null)
                {
                    Console.WriteLine("Incorrect input, exiting");
                    return;
                }

                if (inputString.Equals("done") == true) {
                    finishedInputs = true;
                } else {

                    birthYears[birthYearIndex] = Convert.ToInt32(inputString);

                    // increment the birth year index for each time through the loop
                    birthYearIndex++;

                    // check to see if we are out of slots in the array
                    if( birthYearIndex > maxBirthYearsCount - 1 )
                    {
                        finishedInputs = true;
                    }

                }
            }

            int receivedInputsCount = birthYearIndex;

            // reset the birthYear counter to use it again
            birthYearIndex = 0;

            for( birthYearIndex = 0; birthYearIndex < receivedInputsCount; birthYearIndex++ )
            {
                age[birthYearIndex] = CalculateAge(birthYears[birthYearIndex]);
            }

            /*
             * note that below, the " is escaped as \" such that the compiler
             * doesn't mistake it for the end of the string
             */
            Console.WriteLine("First age is " + age[0]);
            Console.WriteLine("Second age is " + age[1]);

            //double averageAge = CalculateAverageAge(firstAge, secondAge);

            //Console.WriteLine("Average age is " + averageAge);

        }


        static int CalculateAge(int aBirthYear)
        {
            // how to get the current year
            int currentYear = DateTime.Now.Year;

            int age = currentYear - aBirthYear;

            return age;

        }

        static double CalculateAverageAge(int firstAge, int secondAge )
        {
            double averageAge;

            averageAge = ((double)firstAge + (double)secondAge) / 2;

            return averageAge;
        }

    }
}