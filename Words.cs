using System;
using System.Collections.Generic;


namespace Word
{
// Author: Adam Rybak
// the purpose of this class is to build methods for Guess word game. 
// Date Oct 2020.  

    public class Word{
      //  public string _category {get; set;}
        List<string> wordsList {get; set;}

   
    public static void MainWordLists()
        {   
            List<string> wordList = GetWords();
            Console.WriteLine("Words are as follows: " );
            PrintWordList(wordList);           
        }
    public static List<string> GetWords() {
        List<string> wordsList = new List<string>();
        wordsList.Add("Anakonda");
        wordsList.Add("Adam");
        wordsList.Add("Anaya");
        wordsList.Add("Amelia");
        wordsList.Add("Anastasia");
        wordsList.Add("Asia");
        wordsList.Add("Ambrosia");
        wordsList.Add("Aman");
        wordsList.Add("Bruno");
        wordsList.Add("Bart");
        wordsList.Add("Berry");
        wordsList.Add("Brent");
        wordsList.Add("Baron");
        wordsList.Add("Brenda");
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
        List<string> mainList = GetWords();
        string selectedWord="";
        for(int i=0; i<mainList.Count; i++ )
        {
            if(i==wordIndex){selectedWord = mainList[i];}
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
            if(i==0){
                charoutput[0] = input[i];
            }
            else if(i==(maxIndex-1)){
                charoutput[i] = input[i];
            }
            else {
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

