using System;
using System.Collections.Generic;
using System.Text;

namespace LuckySteps
{
    class Player : IPlayer
    {
        public string Username { get; set; }
        public DateTime LastPlayed { get; set;}
        public int Times { get; set; }


        public Player(string username)
        {
            this.Username = username;
            this.Times = 0;
        }


    }
}
