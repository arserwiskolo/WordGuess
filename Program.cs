﻿using System;
using System.Collections.Generic;
using WordGuess.Models;
using WordGuess.Storage;

namespace WordGuess
{
    class Program
    {
        public static void Main(string[] args)
        {            
            var wordStorage = new WordStorageList();
            var playerStorage = new PlayerStorageList();
            var wordGuessSystem = new WordGuessSystem(wordStorage, playerStorage);

            //Console.WriteLine("Welcome to the word guessing game. Please type your FIRST name: ");
            //string nameInput = Console.ReadLine();
            //PrintGreeting(nameInput);
           
            while(true){    
                Console.WriteLine("\nPlease select an option:\n" +
                    "- p: play\n" + 
                    "- q: quit\n" +
                    "- t: print All\n"

                );
                string userInput = Console.ReadLine();  
                if(userInput.ToUpper() == "T")
                {
                    
                    try {

                        List<Word> results = wordGuessSystem.GetAllWords();
                        foreach (var word in results) {
                            Console.WriteLine(word.ToString());
                        } 
                    } catch (Exception e) {
                        Console.WriteLine($"Error: {e.Message}");
                    }
                    
                }

                if(userInput.ToUpper()=="P"){                
                    try{  
                        int numberInput = wordGuessSystem.RandomNumber(1, 12);
                        var mainList = wordGuessSystem.GetAllWords(); 
                        WordGuessSystem selectedWordClass = new WordGuessSystem(wordStorage, playerStorage);// need to instance it due to static method 
                        Word selectedWordObject = selectedWordClass.PickRandomWordStartsWithLetter(numberInput, mainList);
                        var selectedWord = selectedWordObject.Value; 

                        string selectedWordString = Convert.ToString(selectedWord);
                        Word initialWordObj =  new Word();
                        string initialWord = string.Empty;
                        Word modifiedWordObj = new Word();
                        string modifiedWord = string.Empty;
                        
                        Console.WriteLine("\nYour WORD is as follows :\n" + 
                        selectedWordClass.HideLetters(numberInput, mainList).Value);
                        
                        AskForFirstLetter(selectedWord.Length);
                        
                        for(int i = 0; i<=(selectedWord.Length); i++)
                            {             
                                string typedLetterString = Console.ReadLine();
                                int letterInputLength = Convert.ToString(typedLetterString).Length;
                                
                                if (letterInputLength > 1 )
                                {
                                    Console.WriteLine("Incorrect Entry, too many characters!!!\n");       
                                } 
                                else{                            
                                    char typedLetter = Convert.ToChar(typedLetterString);
                                    if (!selectedWordClass.FindLetterInWord(typedLetter, selectedWordObject)) 
                                        {
                                            Console.WriteLine("Missed....");
                                        }
                                    else 
                                        {
                                            Console.WriteLine("\n CONGRATS! You found a letter!\n");

                                        if (modifiedWordObj.Value=="")
                                            {
                                                initialWordObj = selectedWordObject;
                                                modifiedWordObj = selectedWordClass.exposeLetters(typedLetter, selectedWordObject);
                                                Console.WriteLine(modifiedWordObj.Value);
                                            }
                                        else 
                                            {
                                                modifiedWord = selectedWordClass.exposeLetters(typedLetter, selectedWord, modifiedWord);
                                                if(modifiedWord==selectedWord){
                                                    Console.WriteLine("\n WOW....You have found a word. CONGRATS!\n");
                                                    i=(selectedWord.Length);
                                                }
                                                Console.WriteLine("The word is: " + modifiedWord);
                                            }
                                        }// end second else
                                }      
                            NoOfTriesLeft((selectedWord.Length)-i);                   

                            }// end for
                                            
                            if (EndOftheRound() == "N") 
                                {
                                    break;
                                } 
                    }
                        catch (Exception e) 
                        {
                            Console.WriteLine($"Error: {e.Message}");
                        }

                    }// end first if                   

                if(userInput.ToUpper() == "Q")
                {
                    break;
                }
    
            } // end while 
            Console.WriteLine("See you later!");
        }// end Main


        //printing methods
        public static void PrintGreeting(string fname){
            Console.WriteLine($"Hi {fname}, YOU have few words for you to guess. Today's category is:  PEOPLE's FIRST NAMES.");
   
        }

        public static void AskForFirstLetter(int noOfTries){
            Console.WriteLine($"\n Take a guess what Letter this word is missing. You have {noOfTries} guesses. Please type only one letter: ");
        }

        public static string EndOftheRound(){
            Console.WriteLine("Round is over, press any letter...Waiting for your input.....");
            return Console.ReadLine().ToUpper();
        }

        public static void NoOfTriesLeft(int noofTries){
            Console.WriteLine("\n You have " + noofTries + " tries left. \n" );
        }

        
    }
}
