using System;
using System.Collections.Generic;
using WordGuess.Models;
using System.Linq;

namespace WordGuess.Storage
{

    public class PlayerStorageList : IStorePlayers
    {
        private readonly List<Player> _playerList;
        public PlayerStorageList()
        {
            _playerList = new List<Player>();
        }

        public void Create(Player newPlayer){
            _playerList.Add(newPlayer);
            
        }

        public List<Player> GetAll(){
            return _playerList;
        }

         // public Player GetById(long playerId)
        // {
        //     var player = _playerList.Find(x=>x.PlayerId == playerId);
        //     if(player == null){
        //         throw new Exception ($"Player {playerId} does not exist!");
        //     }
        //     return player;
        // }
       
    }
    

}



