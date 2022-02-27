using System;
using System.Collections.Generic;
using System.Text;
using LuckySteps.PlayersListData;

namespace LuckySteps.UserRegistration
{
    class RegistrationChecking : IRegistrationChecking
    {
        public IList<Player> Players { get; set; }
        private IPlayersList _playersData = PlayersList.GetInstance();
        private static RegistrationChecking _instance;
        public static RegistrationChecking GetInstance()
        {
            if (_instance == null) _instance = new RegistrationChecking();
            return _instance;
        }

        public Player CheckUsername(string username)
        {
            foreach (Player player in Players)
            {
                if(player.Username == username) return player;
            }
            return null;
        }
        
        public void CreateNewPlayer(Player player)
        {
           
        }

      
    }
}
