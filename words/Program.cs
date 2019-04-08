using System;
using System.Collections.Generic;

namespace words
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a dictionary with key value pairs to represent words (key)
            //and its definition (value)
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // add several words and their definition
            wordsAndDefinitions.Add("Cohort 30", "Pretty damn cool cohort");
            wordsAndDefinitions.Add("Awesome", "Cohort 30 learning C#");

            // use square bracket lookup to get the definition of a specific word

            // loop over dictionary to get the following output:
            //"The definition of [WORD] is [DEFINITION]"
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The defination of {word.Key} is {word.Value}.");
            }

        }
    }
}
