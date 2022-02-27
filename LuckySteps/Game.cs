using System;
using System.Collections.Generic;
using System.Text;

namespace LuckySteps
{
    class Game : IGame
    {
       // public IList<IPlayer> Players { get; set; }
        public IPlayer Player { get; set; }
        public ITicket Ticket { get; }
        public int ColumnNumber { get; private set; }
        public int Money { get; private set; }
        private bool _checker = true;

        public Game(IPlayer player)
        {
            this.Ticket = new Ticket();
            this.Player = player;
            this.ColumnNumber = 0;
        }

        private void ChosenLeft()
        {
            if (Ticket.Columns[ColumnNumber].Left)
            {
                if (ColumnNumber == 0)
                {
                    Money = 200;
                    
                }
                Money *= 2;
            }
            else
            {
                this._checker = false;
            }
            
        }
        private void ChosenRight()
        {
                if (Ticket.Columns[ColumnNumber].Right)
                {
                    if (ColumnNumber == 0)
                    {
                        Money = 200;

                    }
                    Money *= 2;
                }
            else
            {
                this._checker = false;
            }
        }
        
        public void Play(ConsoleKeyInfo choosenKey)
        {
           
           if(choosenKey.Key == ConsoleKey.LeftArrow)
            {
                ChosenLeft();
            }
           else if(choosenKey.Key == ConsoleKey.RightArrow)
           {
                ChosenRight();
           }
            if(this._checker == false)
            {
                Money = 0;
                return;
            }
            if(this.ColumnNumber == 9)
            {

            }
                ColumnNumber++;
        }


    }
}
