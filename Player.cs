using System;

namespace WordGuess
{

    class Player
{
    public string firstName{get; set;}

    //Base constructor
    public Player(string _firstName){
        if(_firstName.Length>50){
            throw new Exception("Your first name is a bit too long!");
        }
        firstName = _firstName;
    }



    

}
}


