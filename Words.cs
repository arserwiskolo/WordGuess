using System;
using System.Collections.Generic;


namespace Words
{
// Author: Adam Rybak
// the purpose of this class is to 

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
 }
    public static string PickRandomWordStartsWithLetter(int wordIndex){
        List<string> mainList = GetWords();
        string selectedWord="";
        for(int i=0; i<mainList.Count; i++ )
        {
            if(i==wordIndex){selectedWord = mainList[i];}

        }
        return selectedWord;
    }

    public static string HideLetters(){
        string selectedWord = PickRandomWordStartsWithLetter(5);
        char [] input = selectedWord.ToCharArray();
        int maxIndex = input.Length;
        char[] charoutput = new char[maxIndex] ;
        string output = "";
        for(int i = 0; i<maxIndex; i++){
            if(i==0){
                charoutput[0] = input[i];
            }
            if(i==maxIndex){
                charoutput[maxIndex] = input[i];
            }
            else{
             //   charoutput[i] = "_";
            }
            
         output = string.Join("", charoutput);
        }
        return output;
    }
    
}
}


    // char[] charArr = input.ToCharArray();  //convert to char array
     
    // for(int j= 0; j<=charArr.Length-1; j++){
    //     if(charArr[j] =='e' || charArr[j] =='o' || charArr[j] =='i' || charArr[j] =='u'||charArr[j] =='a'){
    //     charArr[j] = ' ';}
    // }

    //     string charsStr = new string(charArr); 
    //     charsStr = charsStr.Replace(" ", String.Empty); 
    //     Console.WriteLine(charsStr);