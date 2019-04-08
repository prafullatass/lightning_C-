using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            // Now, we are going to rebuild the structure of our data. Instead of one dictionary
            //with key value pairs for words and definitions. We want to track more than just
            //the word and its definition, so we are going to build a list of dictionaries.

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            // We want to track the following about each word: word, definition, part of speech,
            //example sentence

            /*
                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
             */

            // create dictionary to represent a few word
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#!");

            // Add dictionaries to your list
            dictionaryOfWords.Add(excitedWord);
            // create another dictionary and add that to the list
            Dictionary<string, string> FunWord = new Dictionary<string, string>();
            FunWord.Add("Word", "Fun");
            FunWord.Add("definition", "Enjoying the moment");
            FunWord.Add("part of speech", "adjective");
            FunWord.Add("example sentence", "Studying is Fun!!");
            dictionaryOfWords.Add(FunWord);

            // loop over your list of dictionaries and output the data
            // foreach(KeyValuePair<string, String> word in excitedWord)
            // {
            //     Console.WriteLine($"{word.Key} : {word.Value}");
            // }
            /*
            Example output for one word in the list of dictionaries:
                word: excited
                definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                part of speech: adjective
                example sentence: I am excited to learn C#!
             */

            // iterate list
            Console.WriteLine("Showing list of Dictionary");
            foreach (Dictionary<string,string> list in dictionaryOfWords)
            {
                // iterate key value pair of dictionary
                foreach (KeyValuePair<string,string> kvp in list)
                {
                    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
