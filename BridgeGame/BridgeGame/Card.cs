using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeGame
{
    class Card
    {
        private string suit;
        private string type;
        private int value;

        public Card(string suit, string type, int value)
        {
            this.suit = suit;
            this.type = type;
            this.value = value;
        }
    }
}
