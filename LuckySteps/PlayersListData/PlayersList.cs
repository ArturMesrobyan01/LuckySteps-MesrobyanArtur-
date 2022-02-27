using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace LuckySteps.PlayersListData
{
    class PlayersList : IPlayersList
    {
        private string _path = @"//PlayersListData//PlayersList";
        private static PlayersList _instance;
        private  PlayersList()
        {        }

        public static PlayersList GetInstance()
        {
            if (_instance == null) _instance = new PlayersList();
            return _instance;
        }

        public IList<IPlayer> GetPlayersList()
        {
            string json = File.ReadAllText(_path);
            return JsonConvert.DeserializeObject<List<IPlayer>>(json);
        }    
        public void SetPlayersList(IList<IPlayer> players)
        {
            string json = JsonConvert.SerializeObject(players);
            File.WriteAllText(_path, json);
        }

    }
}
