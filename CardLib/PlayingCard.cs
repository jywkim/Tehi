using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public enum CardSuit
    {
        Clubs, Diamonds, Hearts,
        Spades
    }

    public class PlayingCard
    {
        private bool faceUp;        public int Rank { get; private set; }        public CardSuit Suit { get; private set; }
    }
}
