using System;
using System.Collections.Generic;
using System.Text;

namespace Slutprojekt
{
    class Roulette : BaseGame
    {
        private Random _random;

        public Roulette()
        {
            _name = "Roulette";
        }

        public override void Play()
        {
            var playAgain = true;

            while (playAgain)
            {
                uint bet = 0;



                { // Get the user's bet
                    Console.WriteLine("how much will you bet?");

                    var input = Console.ReadLine();

                    while (!uint.TryParse(input, out bet) || bet > User.Money)
                    {
                        Console.WriteLine("please write a number more than 0 and less than the amount of money you have");
                        input = Console.ReadLine();
                    }
                }

                { // Check if user wants to play again
                    Console.WriteLine("Do you want to play again? Y or N");

                    var input = Console.ReadLine().ToLower();

                    while (input != "y" || input != "n")
                    {
                        Console.WriteLine("please write Y or N (case insensitive)");
                        input = Console.ReadLine().ToLower();
                    }

                    if(input == "y")
                    {
                        playAgain = true;
                    }
                    else if (input)
                    {

                    }

                }
            }
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
