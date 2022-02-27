using System;
using System.Collections.Generic;
using System.Text;

namespace LuckySteps
{
    interface IPlayer
    {
        string Username { get; set; }
        DateTime LastPlayed { get; set; }
        int Times { get; set; }

    }
}
