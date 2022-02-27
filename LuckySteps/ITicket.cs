using System;
using System.Collections.Generic;
using System.Text;

namespace LuckySteps
{
    interface ITicket
    {
        IList<Column> Columns { get; }
        Column CurrentColumn { get; set; }
        
    }
}
