using System;
using System.Collections.Generic;


namespace WordGuess.Models
{
// Author: Adam Rybak
// the purpose of this class is to build methods for Guess word game. 
// Date Oct 2020.  


    public class Word{
        // public Word(long id, string category, string value){
        //     Id = id;
        //     Category = category;
        //     Value = value;
        // }

        public long Id {get; set;}
        public string Category {get; set;}
        public string Value {get; set;}

        public override string ToString()
        {
            string details = $"\n----- Word {Id} -----\n";
            details += $"Category: {Category}\n";
            details += $"Value: {Value}\n";
            details += "-------------------------\n";
            return details;
        }
    }
}

