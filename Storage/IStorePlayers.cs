using System;
using System.Collections.Generic;
using WordGuess.Models;

namespace WordGuess.Storage
{

    public interface IStorePlayers
    {        
        void Create(Player newPlayer);
        
        List<Player> GetAll();
        
    }
    
}



