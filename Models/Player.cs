using System;

namespace WordGuess.Models
{

    public class Player
{
    //base construstror
    public Player(long playerId, string firstName) {
        PlayerId = playerId;
        FirstName = firstName;
    }
    public long PlayerId {get;}
    public string FirstName {get; private set;}

    //Base constructor
    public string GetPlayer(string _firstName){
        if(_firstName.Length>50){
            throw new Exception("Your first name is a bit too long!");
        }
        return _firstName;
    }

    public override string ToString()
        {
            string details = $"\n----- Player {PlayerId} -----\n";
            details += $"Name: {FirstName}\n";           
            return details;
        }



    

}
}


