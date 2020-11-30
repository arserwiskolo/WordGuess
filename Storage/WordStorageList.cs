using System;
using System.Collections.Generic;
using System.Linq;
using WordGuess.Models;


namespace WordGuess.Storage
{

    public class WordStorageList : IStoreWords
    {
        private readonly List<Word> _wordList;

        public WordStorageList(){
            _wordList = new List<Word>();
        }

        public void Create(Word newWord){
            _wordList.Add(newWord);
        }
        
       
        public List<Word> GetByCategory(string category){
            return _wordList.Where(x => x.Category.ToLower() == category.ToLower()).ToList();
        }

        public List<Word> GetAll(){
            return _wordList;
        }

        }
}






