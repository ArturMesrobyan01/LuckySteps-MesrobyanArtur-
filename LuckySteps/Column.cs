using System;
using System.Collections.Generic;
using System.Text;

namespace LuckySteps
{
    class Column
    {
       public bool Right;
       public bool Left;

        public Column()
        {
            Random random = new Random();
            bool randomBool = random.Next(2) == 1; // 0 = false, 1 = true;
            this.Right = randomBool;
            this.Left = !(randomBool);
        }
            
    }
}
