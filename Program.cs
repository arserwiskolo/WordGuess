using System;
using Words;

namespace WordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Word guessing game. Please type your First Name: ");
            string nameInput = Console.ReadLine();
            PrintGreeting(nameInput);
            Console.WriteLine("WARNING: typing QUIT will stop your game!");
            while(true){      
                //pick first word from the DB and display to the player.
               Console.WriteLine(Word.PickRandomWordStartsWithLetter(5));
               Console.WriteLine(Word.HideLetters());
                //Display only first and last letter for the word. 


                // accept input from player. 

                // place input into the letter for the selected word. 

                

                string userInput = Console.ReadLine();
                if (userInput == "QUIT") {
                    break;
                }
            }
            //print words. 
           // Word.MainWordLists();
        
        
            //string userInput = Console.ReadLine();
        }

    public static void PrintGreeting(string fname){
    Console.WriteLine("Welcome "+  fname + ", it is a please to have you here.");
    Console.WriteLine("This is a word game and we have few words for you to guess. ");
    Console.WriteLine("Let's start with knowing few words. ");
}

   

    }
}
