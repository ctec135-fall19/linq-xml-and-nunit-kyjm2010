//Author: Kyle McDonald
//Date:   11/2/2019
//CTEC 135: Microsoft Software Development with C# 

//Module 6, Programming Assignment 5, Problem 3

//XML Using LINQ

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath1ConsoleApp
{
    class Program
    {
        #region IPO
        // description: Program that familiarizes us with unit testing
        // Inputs: ushort variables x and y, numbers 1, 9, 100 and 900
        // Outputs: First output prints 9 which is the desired outcome
        //second output is 24,464 which is not the desired output of 100 x 900.
        //Third output once again shows 9 which is desired, the fourth output
        //throws an error beause the number generated is outside the ushort 
        //range.
        // Behavior: Main prgoram calls the classes MyMath1 and MyMath2 in 
        //order to multiply two numbers together. Initially the outputs are 
        //uncheccked in MyMath1 and therefore show the overflow for the numbers 
        //that are outside the range of the ushort type. MyMath 2, the formula
        //is surrounded byu a check boxwhich throws an error if the number 
        //generated is outside the scope of the number type. If we use a try 
        //catch statement we can allow the program to continue without crashing
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("1 x 9 = {0}", MyMath1.Multiply((ushort)1, 9));
            Console.WriteLine("10 x 50 = {0}", MyMath1.Multiply((ushort)100, 900));

            Console.WriteLine("1 x 9 = {0}", MyMath2.Multiply((ushort)1, 9));

            try
            {
                Console.WriteLine("10 x 50 = {0}", MyMath2.Multiply((ushort)100, 900));
            }
            catch(System.OverflowException)
            {
                Console.WriteLine("The number is larger than 65,535");
            }

            
        }
    }
}
