using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeGame
{
    class Deck
    {
        private Card[] deck;
        private string[] suit;
        private string[] value;

        public Deck()
        {
            deck = new Card[52];
            suit = new string[] {"Hearts", "Clubs", "Spades", "Diamonds"};
            value = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };            
        }

        public void CreateDeck()
        {
            for (int i = 0; i < suit.Length; i++)
            {
                for (int j = 0; j < value.Length; j++)
                {
                    deck[(i + 1) * (j+ 1)] = new Card(i, j, 0);
                }
            }
        }

        public void Shuffle()
        {
            
        }
    }
}
