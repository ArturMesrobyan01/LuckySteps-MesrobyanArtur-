using System;
using System.Collections.Generic;
using System.Text;

namespace LuckySteps
{
    class Ticket : ITicket
    {
        public IList<Column> Columns { get; } = new Column[10];
        public Column CurrentColumn { get; set; }

        public Ticket()
        {
            for(int i = 0; i < 10; i++)
            {
                Columns[i] = new Column();
            }
        }
    }
}
