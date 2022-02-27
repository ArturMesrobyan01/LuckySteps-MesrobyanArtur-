using System;
using System.Collections.Generic;
using System.Text;

namespace LuckySteps
{
    interface IGame
    {
       // IList<IPlayer> Players { get; set; }
        IPlayer Player { get; set; }
        ITicket Ticket { get; }
    }
}
