using System;
using System.Collections.Generic;
using LuckySteps.LoggerData;
using LuckySteps.UserRegistration;

namespace LuckySteps
{
    class UI
    {
        RegistrationChecking checking = RegistrationChecking.GetInstance();
        Logger logger = Logger.GetInstance();
        public void Start()
        {
            a:
            Console.WriteLine("\t\t\tHello 'Lucky Steps' game\n");
            Console.WriteLine("Choose Command\n");
            Console.WriteLine("\t1.Log in \t\t2.Register \t\tEsc.Quit");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            switch (key.Key)
            {
                case ConsoleKey.Escape:
                    return;
               
                case ConsoleKey.NumPad1:
                    Console.WriteLine("Write your username, please");
                    string username = Console.ReadLine();
                    Player player = checking.CheckUsername(username);
                    break;
                case ConsoleKey.NumPad2:
                   
                    break;
                default:
                    goto a;
                    
            }

        }
        public void StartGame(Player player)
        {
            if (player.Times == 3)
            {
                Console.WriteLine($"You Cann't play untill {player.LastPlayed}");
                    return;
            }
            player.LastPlayed = DateTime.Now;
            player.Times++;
        a:
            Game game = new Game(player);
            Console.WriteLine($"Dear {player.Username} we begin game");
           
             Console.WriteLine("Choose the column\n");
             Console.WriteLine("Right arrow. Right Column \t\tLeft arrow. Left Column ");
             Console.WriteLine("Esc. Stop the game");
             ConsoleKeyInfo key = Console.ReadKey();
             Console.Clear();
             if(key.Key == ConsoleKey.Escape)
             {
                int level = (game.ColumnNumber)+ 1;
                Console.WriteLine($"You earned {game.Money} money {level} Level. \nCongrats!!");
                logger.Info($"{player.Username} user reached {level} row");
             }
             game.Play( key);
            
        }

    }
}
