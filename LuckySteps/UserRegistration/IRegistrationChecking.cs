using System;
using System.Collections.Generic;
using System.Text;

namespace LuckySteps.UserRegistration
{
    interface IRegistrationChecking
    {
        IList<Player> Players { get; set; }
    }
}
