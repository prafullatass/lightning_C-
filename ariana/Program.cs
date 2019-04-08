﻿using System;
using System.Collections.Generic;

namespace ariana
{
    class Program
    {
        static void Main(string[] args)
        {
           // Ariana's boyfriends
            // Pete Davidson
            // Ricky Alvarez
            // Big Sean
            // Jai Brooks
            // Nathan Sykes
            // Graham Phillips

            Dictionary<string, string> boyfriends = new Dictionary<string, string>();

            // Add Ariana's boyfriends to the boyfriends dictionary with the {key name, value boyfriend} ex. {Big Sean, boyfriend}
            boyfriends.Add("Pete Davidson", "boyfriend");
            boyfriends.Add("Ricky Alvarez", "boyfriend");
            boyfriends.Add("Big Sean", "boyfriend");
            boyfriends.Add("Jai Brooks", "boyfriend");
            boyfriends.Add("Nathan Sykes", "boyfriend");
            boyfriends.Add("Graham Phillips", "boyfriend");

            // I want you to change the value boyfriend to ex-boyfriend ex {Big Sean, ex-boyfriend},
            //if Pete Davidson change the value to ex-fiance ex {Pete Davidson, ex-fiance}

            Dictionary<string, string> UpdatedBoyfriends = new Dictionary<string, string>();
            foreach(KeyValuePair<string, string> bf in boyfriends)
            {
                if(bf.Key == "Pete Davidson")
                {
                    UpdatedBoyfriends.Add(bf.Key, "ex-fiance");
                }
                else
                 {
                    UpdatedBoyfriends.Add(bf.Key, "ex-boyfriend");
                }

            }
            // display the results "Ariana's {value} is {key}"

            foreach(KeyValuePair<string, string> bf in UpdatedBoyfriends)
            {
                Console.WriteLine($"{bf.Key} : is Ariana's {bf.Value} ");
            }
        }
    }
}
