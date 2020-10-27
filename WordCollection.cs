using System;
using System.Collections.Generic;
using Word;


namespace WordGuess
{

    public class WordCollection{
        
        //consrtuctor
        public WordCollection(){
           var _wordList = new List<Word>();

           var word1  = new Word("Name","Anakonda");
           var word2  = new Word("Name","Adam");
           var word3  = new Word("Name","Anaya");
           var word4  = new Word("Name","Amelia");
           var word5  = new Word("Name","Anastasia");
           var word6  = new Word("Name","Asia");
           var word7  = new Word("Name","Ambrosia");
           var word8  = new Word("Name","Aman");
           var word9  = new Word("Name","Bruno");
           var word10 = new Word("Name","Bart");
           var word11 = new Word("Name","Berry");
           var word12 = new Word("Name","Brenda");

           _wordList.Add(word1);
           _wordList.Add(word2);
           _wordList.Add(word3);
           _wordList.Add(word4);
           _wordList.Add(word5);
           _wordList.Add(word6);
           _wordList.Add(word7);
           _wordList.Add(word8);
           _wordList.Add(word9);
           _wordList.Add(word10);
           _wordList.Add(word11);
           _wordList.Add(word12);
        }
        //List<string> wordsList {get; set;}
        private List<Word> _words;
        

        public static void MainWordList()
            {   
                List<string> wordValuesList = new List<string>();
                List<Word> wordList = GetWords();
                foreach(Word _word in wordList)
                {
                    wordValuesList.Add(_word.Value);
                }
                //GetWords();
                Console.WriteLine("Words are as follows: " );
                PrintWordList(wordValuesList);           
            }
        public static List<Word> GetWords() {
            List<Word> wordsList = new List<Word>();
            
           var word1 = new Word("Name","Anakonda");
           var word2 = new Word("Name","Adam");
           var word3 = new Word("Name","Anaya");
           var word4 = new Word("Name","Amelia");
           var word5 = new Word("Name","Anastasia");
           var word6 = new Word("Name","Asia");
           var word7 = new Word("Name","Ambrosia");
           var word8 = new Word("Name","Aman");
           var word9 = new Word("Name","Bruno");
           var word10 = new Word("Name","Bart");
           var word11 = new Word("Name","Berry");
           var word12 = new Word("Name","Brenda");

            wordsList.Add(word1);
            wordsList.Add(word2);
            wordsList.Add(word3);
            wordsList.Add(word4);
            wordsList.Add(word5);
            wordsList.Add(word6);
            wordsList.Add(word7);
            wordsList.Add(word8);
            wordsList.Add(word9);
            wordsList.Add(word10);
            wordsList.Add(word11);
            wordsList.Add(word12);
         
            return wordsList;
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

        public static string PickRandomWordStartsWithLetter(int wordIndex){
            List<Word> mainList = GetWords();
            string selectedWord="";
            for(int i=0; i<mainList.Count; i++ )
                {
                Word nextWord = mainList[i];
                if(i==wordIndex){selectedWord = nextWord.Value;}
            }
            return selectedWord;
        }//

        public static string HideLetters(int wordIndex){
            string selectedWord = PickRandomWordStartsWithLetter(wordIndex);
            char [] input = selectedWord.ToCharArray();
            int maxIndex = input.Length;
            char[] charoutput = new char[maxIndex] ;
            string output = "";
            for(int i = 0; i<maxIndex; i++){
                if(i==0)
                {
                    charoutput[0] = input[i];
                }
                else if(i==(maxIndex-1))
                {
                    charoutput[i] = input[i];
                }
                else 
                {
                    charoutput[i] = Convert.ToChar("-");
                }                
            output = string.Join("", charoutput);
            }
            return output;
        }//

        public static Boolean FindLetterInWord(char letter, string word){
            char[] charWord = word.ToCharArray();
            int max = (charWord.Length-1);

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
            string output = "";
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
            string output = "";
            for(int i = 1; i<maxIndex; i++){
                if (input[i] != letter){
                    if (modifiedInput[i] == Convert.ToChar("-")){
                        input[i] = Convert.ToChar("-");
                    }
                }
            output = string.Join("", input);
            }       
        return output;
        }

}
}


