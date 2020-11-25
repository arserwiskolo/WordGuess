using System;
using System.Collections.Generic;
using WordGuess.Models;

namespace WordGuess.Storage
{

    public interface IStoreWords
    {
        void Create(Word newWord);

        //Word GetById(long id);

        List<Word> GetByCategory(string category);

        List<Word> GetAll();

    }
}