using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// File/Project Prolog
// Name: Matthew Vaughan
// CS 1400 Section 003
// Project: Lab 22
// Date: 03/28/2016 2:30:27 PM
//
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Lab22
{
    class Program
    {

        static void Main(string[] args)
        {
            //Declare a Constant
            const int
                TEN = 10;

            //Declare the array
            int[] examScores = new int[TEN];

            //Create a for loop that will store the users input in an array
            for(int i = 0; i < 9; i++)
            {
                //Prompt the user to enter a value
                Console.WriteLine("Please add a Value");

                //Store the value in the array
                examScores[i] = int.Parse(Console.ReadLine());
            }

            //Display the result from the method that adds the array
            Console.WriteLine($"The total of the values you entered is {AddArray(examScores)}");

            //End the console app with a readline
            Console.ReadLine();
        }

        /// <summary>
        /// Adding array method
        /// </summary>
        /// <param name="array"></param>
        /// <returns="arraySum"></returns>
        public static int AddArray(int[] array)
        {
            //Declare loop variable
            int arraySum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                //Add the array value to the sum
                arraySum += array[i];
            }

            //return array sum
            return arraySum;
        }
    }
}
