//Author: Kyle McDonald
//Date:   11/2/2019
//CTEC 135: Microsoft Software Development with C# 

//Module 6, Programming Assignment 5, Problem 1

    //LINQ

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_1_LINQ
{
    class Program
    {
        #region IPO
        // description: Program that familiarizes us with the use of LINQ 
        //Queries
        // Inputs: String arrayu with various pasta names
        // Outputs: return defined values and/or data that is changed. First 
        //information returned is the items of the string array that begin with
        //the letters a-f. Second output is the same but with an added noodle.
        //The last output uses a modified list returned to the main mehtod and
        //prints the values specified
        // Behavior: String array is built and passed into the static method
        //PastaQuery. LINQ query determines if each element of the array begins
        //with a OR b OR c OR d OR e OR f and assigns that value to subset if 
        //true. Subset is then ran through a foreach loop to priont each pasta.
        //A new value is added to the string array and the Query is run again
        //showing the added value. Another value is added and the array is 
        //compiled into a list, then returned to main where it is printed.
        #endregion

        static void Main(string[] args)
        {
            //creates an array of strings (the ordering of the strings should be random)    
            string[] pastas = { "vermicelli", "bucatini",

                "linguine", "angel hair", "mafalde", "fettuccinie", "gemelli",
                "capellini", "ziti", "eliche", "orzo", "ditali" };

            #region return results

            //output the returned result

            List<string> pastaList = PastaQuery(pastas);

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Returned results from LINQ query method");
            Console.WriteLine("---------------------------------------");

            foreach (string s in pastaList)

            {

                Console.WriteLine("Item: {0}", s);

            }

            Console.WriteLine();

            #endregion

        }

        #region immediate and deferred execution

        static List<string> PastaQuery(string[] pastas)

        {

            //create a LINQ statement that returns the strings that start with
            //'a' - 'f'

            var subset = from pasta in pastas

                         where pasta.StartsWith("a") || pasta.StartsWith("b") 
                         || pasta.StartsWith("c") || pasta.StartsWith("d") ||
                         pasta.StartsWith("e") || pasta.StartsWith("f")
                         orderby pasta
                         select pasta;

            // LINQ query is executed 
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("Immediate results using LINQ query");
            Console.WriteLine("------------------------------------");

            foreach (var s in subset)

                Console.WriteLine(s);

            Console.WriteLine();



            // demonstrate reuse of query
            //modify the array in such a way that the result will be different
            pastas[0] = "bow Tie";

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Immediate results using LINQ query after change to data");
            Console.WriteLine("-------------------------------------------------------");

            foreach (var s in subset)

                Console.WriteLine(s);

            Console.WriteLine();

            //modify the array in such a way that the result will be different
            pastas[2] = "butterfly";

            //immediate execution
            //capture the result as a List<string> object and return it
            List<string> pastaList = (from pasta in pastas

                                      where pasta.StartsWith("a") || pasta.StartsWith("b")
                                        || pasta.StartsWith("c") || pasta.StartsWith("d") ||
                                        pasta.StartsWith("e") || pasta.StartsWith("f")

                                       orderby pasta

                                       select pasta).ToList<string>();

            return pastaList;

        }

        #endregion

    }
}
