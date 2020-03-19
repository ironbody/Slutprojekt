using System.Collections.Generic;

namespace Slutprojekt
{
    public class Casino
    {
        private List<BaseGame> games;

        public Casino()
        {
            // TODO: Generate a random assortment of games

            games.Add(new Roulette());
        }

        public void ShowGames()
        {

        }

        public void PlayGame(int index)
        {

        }
    }
}