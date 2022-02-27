using System;
using System.Collections.Generic;
using System.Text;

namespace LuckySteps
{
    interface IPlayersList
    {
        IList<IPlayer> GetPlayersList();
        void SetPlayersList(IList<IPlayer> players);
    }
}
