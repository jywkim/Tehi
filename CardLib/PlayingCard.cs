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
        private bool faceUp;        public int Rank { get; private set; }        public CardSuit Suit { get; private set; }        public PlayingCard(int rank, CardSuit suit)
        {
            Rank = rank;
            Suit = suit;
            faceUp = false;
        }

        public void Flip()
        {
            faceUp = !faceUp;
        }

        public override string ToString()
        {
            if (!faceUp) return "XX";
            string suits = "\u2663\u2666\u2665\u2660";
            string ranks = " A23456789TJQK";
            return "" + ranks[Rank] + suits[(int)Suit];
        }
    }
}
