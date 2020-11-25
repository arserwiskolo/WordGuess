using System;
using System.Collections.Generic;
using WordGuess.Models;
using WordGuess.Storage;

namespace WordGuess
{

    public class WordGuessSystem
    {
        
        //consrtuctor
        public WordGuessSystem(IStoreWords wordStorage, IStorePlayers playerStorage)
        {
            //Dependency injections

            _playerStorage = playerStorage;
            _wordStorage = wordStorage;

            var newWord1 = new Word(){Id = 100, Category = "People Name", Value = "Anakonda" };
            var newWord2 = new Word(){Id = 101, Category = "People Name", Value = "Adam" };
            var newWord3 = new Word(){Id = 102, Category = "People Name", Value = "Anaya"  };
            var newWord4 = new Word(){Id = 103, Category = "People Name", Value = "Amelia" };
            var newWord5 = new Word(){Id = 104, Category = "People Name", Value = "Anastasia" };
            var newWord6 = new Word(){Id = 105, Category = "People Name", Value = "Ambrosia" };
            var newWord7 = new Word(){Id = 106, Category = "People Name", Value = "Aman" };
            var newWord8 = new Word(){Id = 107, Category = "People Name", Value = "Bruno" };
            var newWord9 = new Word(){Id = 108, Category = "People Name", Value = "Bart" };
            var newWord10 = new Word(){Id = 109, Category = "People Name", Value = "Berry" };
            var newWord11 = new Word(){Id = 110, Category = "People Name", Value = "Brendan" };
          
            _wordStorage.Create(newWord1);
            _wordStorage.Create(newWord2);
            _wordStorage.Create(newWord3);
            _wordStorage.Create(newWord4);
            _wordStorage.Create(newWord5);
            _wordStorage.Create(newWord6);
            _wordStorage.Create(newWord7);
            _wordStorage.Create(newWord8);
            _wordStorage.Create(newWord9);
            _wordStorage.Create(newWord10);
            _wordStorage.Create(newWord11);

            _playerStorage.Create(new Player(111111, "Adam"));
            _playerStorage.Create(new Player(111112, "Will"));

        }
        
        /*** STORAGE ***/
        private readonly IStorePlayers _playerStorage;
        private readonly IStoreWords _wordStorage;
               
        //Methods
        public List<Word> GetAllWords(){
            return _wordStorage.GetAll();
        }

        public Word AddNewWord(Word newWord) {
            _wordStorage.Create(newWord);
            return newWord;
        }

        public int RandomNumber(int min, int max)  
        {  
            int randomInt = new Random().Next(min, max);
            return randomInt; 
        } 
        
        public static void PrintWordList(List<string> listToPrint) {
            Console.WriteLine("----------");
            List<string> listToReturn = new List<string>();
            for (int i = 0; i < listToPrint.Count; i++) {
                if (listToPrint[i].Length>0){
                    listToReturn.Add(listToPrint[i]);
                    }
                else {}
                Console.WriteLine(listToReturn[i]);
            }
        }//

        public static string PickRandomWordStartsWithLetter(int wordIndex, List<Word> words ){
            string selectedWord=string.Empty;
            for(int i=0; i<words.Count; i++)
                {
                Word nextWord = words[i];
                if(i==wordIndex){selectedWord = nextWord.Value;}
                }
            return selectedWord;
        }//

        public static string HideLetters(int wordIndex, List<Word> words)
        {
            string selectedWord = PickRandomWordStartsWithLetter(wordIndex, words);
            char [] input = selectedWord.ToCharArray();
            int maxIndex = input.Length;
            char[] charoutput = new char[maxIndex];
            string output = string.Empty;
            for(int i = 0; i<maxIndex; i++){
                if(i==0){charoutput[0] = input[i];}
                else if(i==(maxIndex-1)){charoutput[i] = input[i];}
                else{charoutput[i] = Convert.ToChar("-");}                
            output = string.Join("", charoutput);
            }
            return output;
        }//

        public static Boolean FindLetterInWord(char letter, string word){
            char[] charWord = word.ToCharArray();
            int max = (charWord.Length-2);
            for(int i=1; i <= max; i++ ){
                if (charWord[i] == letter){
                    return true;
                }
            }       
        return false;
        }//

        public static string exposeLetters(char letter, string word){
            char [] input = word.ToCharArray();
            int maxIndex = (input.Length-1);
            string output = string.Empty;
            for(int i = 1; i<maxIndex; i++){
                if (input[i] != letter){
                    input[i] = Convert.ToChar("-");
                }
            output = string.Join("", input);
            }       
        return output;
        }

        public static string exposeLetters(char letter, string word, string modifiedWord){
            char [] input = word.ToCharArray();
            char [] modifiedInput = modifiedWord.ToCharArray();
            int maxIndex = (input.Length-1);
            string output = string.Empty;
            for(int i = 1; i<maxIndex; i++){
                if (input[i] != letter){
                    if (modifiedInput[i] == Convert.ToChar("-")){
                        input[i] = Convert.ToChar("-");
                    }
                }
            output = string.Join("", input);
            }       
        return output;
        }//

    }
}// last


