using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstgame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stake = 0;
            string userInput;
            Console.WriteLine("Hi player, please choose your name");
            string name = Console.ReadLine();
            player newPlayer = new player(name);
            Console.WriteLine("Your current balance: " + newPlayer.balance);
            bool validBet = false;
            while (!validBet)
            {
                Console.WriteLine("Enter your stake: ");
                if (int.TryParse(Console.ReadLine(), out stake))
                {
                    if (newPlayer.balance >= stake && stake > 0)
                    {
                        validBet = true;
                        newPlayer.PlaceBet(stake);
                        Console.WriteLine($"You have placed a bet of {stake}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid bet. You either don't have enough funds or you placed a negative bet.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

            Console.WriteLine($"Hi {name}, please choose what you want to do\nb for blackjack \ns for stop playing");
            Console.WriteLine($"Your current balance: {newPlayer.balance}");
            userInput = Console.ReadLine().ToLower();
            bool continuePlaying = true;

            while (continuePlaying)
            {
                switch (userInput)
                {
                    case "b":

                        PlayBlackjack(newPlayer, stake);
                        break;
                    case "s":
                        continuePlaying = false;
                        break;
                    default:
                        Console.WriteLine("Wrong user input\n");
                        break;
                }
                if (continuePlaying)
                {

                    Console.WriteLine($"Your current balance: {newPlayer.balance}");
                    Console.WriteLine("\nDo you want to play another game? (y/n): ");
                    userInput = Console.ReadLine().ToLower();

                    switch (userInput)
                    {
                        case "y":
                            Console.WriteLine("Enter the amount you want to bet: ");
                            if (int.TryParse(Console.ReadLine(), out stake))
                            {
                                if (newPlayer.balance < stake)
                                {
                                    Console.WriteLine("Not enough funds. Please bet a lower stake.");
                                }
                                else
                                {
                                    newPlayer.PlaceBet(stake);
                                    PlayBlackjack(newPlayer, stake);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid bet amount.");
                            }
                            break;
                        case "n":
                            continuePlaying = false;
                            break;

                        default:
                            Console.WriteLine("Invalid input. Please choose 'y' or 'n'.");
                            break;
                    }
                }
            }
            Console.WriteLine("\nThank you for playing! Goodbye.");
        }

        private static void PlayBlackjack(player player, int stake)
        {

            blackjack blackjackGame = new blackjack(player);
            player.Resethand();
            blackjackGame.DealCards();
            blackjackGame.ShowCards();

            bool playerTurn = true;
            while (playerTurn)
            {
                Console.WriteLine("\nWould you like to [Hit] (Enter) or [Stand] (Space)?");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    blackjackGame.PlayerHit();
                    if (player.CalculatehandValueBlackjack() > 21)
                    {
                        Console.WriteLine("\nYou busted!");
                        playerTurn = false;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    blackjackGame.PlayerStand();
                    playerTurn = false;
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please press Enter for [Hit] or Space for [Stand].");
                }
            }

            blackjackGame.DealerTurn();
            blackjackGame.DetermineWhoWon(stake);
        }
    }
}
