using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public class FaceCard : PlayingCard
    {
        public int Eyes { get; private set; }

        public FaceCard(int rank, CardSuit suit)
            : base(rank, suit)
        {
            Eyes = 2;
            if ((rank == Jack) && (suit == CardSuit.Hearts))
            {
                Eyes = 1;
            }
            if ((rank == Jack) && (suit == CardSuit.Spades))
            {
                Eyes = 1;
            }
            if ((rank == King) && (suit == CardSuit.Diamonds))
            {
                Eyes = 1;
            }
        }
    }
}
