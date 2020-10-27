using System;
using Word;

namespace WordGuess
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Welcome to the word guessing game. Please type your FIRST name: ");
            string nameInput = Console.ReadLine();
            PrintGreeting(nameInput);
           
            while(true){    
                Console.WriteLine("q - quit; p-play");
                string userInput = Console.ReadLine();  

                if(userInput.ToUpper()=="P"){
                
                    Console.WriteLine("Pick number from 1-12");
                    int numberInput = Convert.ToInt32(Console.ReadLine());
                   
                    string pickedWord = Convert.ToString(WordCollection.PickRandomWordStartsWithLetter(numberInput)); 
                   
                    Console.WriteLine(WordCollection.HideLetters(numberInput));

                    AskForFirstLetter(pickedWord.Length);
                    
                    string modifiedWord = "";
                    string initialWord = "";
                    for(int i = 0; i<=(pickedWord.Length); i++)
                    {   
                        char selectedLetter = Convert.ToChar(Console.ReadLine());
                                              
                            if (!WordCollection.FindLetterInWord(selectedLetter, pickedWord)) 
                                {
                                    Console.WriteLine("Missed....");
                                }
                            else 
                                {
                                    Console.WriteLine("CONGRATS! You found a letter!");

                                if (modifiedWord==""){
                                    initialWord = pickedWord;
                                    modifiedWord = WordCollection.exposeLetters(selectedLetter, pickedWord);
                                    Console.WriteLine(modifiedWord);
                                    }
                                else 
                                {
                                    modifiedWord = WordCollection.exposeLetters(selectedLetter, pickedWord, modifiedWord);
                                    if(modifiedWord==pickedWord){
                                        Console.WriteLine("WOW....You have found a word. CONGRATS!"  );
                                        i=(pickedWord.Length);
                                    }
                                    Console.WriteLine(modifiedWord);
                                }
                                }
                                
                    NoOfTriesLeft((pickedWord.Length)-i);                   

                    }// end for
                                       
                    if (EndOftheRound() == "N") {
                        break;
                        } 
                    }
                if(userInput.ToUpper() == "Q"){
                    break;
                }               

            } // end while 
            Console.WriteLine("See you later!");
        }


        //methods
        public static void PrintGreeting(string fname){
            Console.WriteLine("Hi " + fname);
            Console.WriteLine("YOU have few words for you to guess. Today's category is:  PEOPLE FIRST NAMES");
   
        }

        public static void AskForFirstLetter(int noOfTries){
            Console.WriteLine("What Letter this word is missing? You have " + noOfTries + " guesses. Please type only one letter: ");
        }

        public static string EndOftheRound(){
            Console.WriteLine("Round is over, Do you want to play again: Y- yes, any letter - No. Waiting for your input.....");
            return Console.ReadLine().ToUpper();
        }

        public static void NoOfTriesLeft(int noofTries){
            Console.WriteLine("You have " + noofTries + " tries left" );
        }

        
    }
}
