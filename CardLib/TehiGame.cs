using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public class TehiGame : IEnumerable<PlayingCard>
    {
        public int HandsDealt { get; private set; }
        public int BestHandScore { get; private set; }

        private CardDeck deck = new CardDeck();
        List<PlayingCard> hand = new List<PlayingCard>();

        public int Score
        {
            get
            {
                int totalEyes = 0;
                int totalRank = 0;
                foreach (PlayingCard card in hand)
                {
                    if (card is FaceCard)
                    {
                        FaceCard face = (FaceCard)card;
                        totalEyes += face.Eyes;
                    }
                    else totalRank += card.Rank;
                }
                return totalRank * totalEyes;
            }
        }

        public void Deal()
        {
            foreach (PlayingCard card in hand) deck.Add(card);
            hand.Clear();
            deck.Shuffle();
            for (int i = 0; i < 5; i++)
            {
                PlayingCard card = deck.Deal();
                card.FaceUp = true;
                hand.Add(card);
            }
            HandsDealt++;
            if (Score > BestHandScore)
                BestHandScore = Score;
        }

        public override string ToString()
        {
            string rep = string.Empty;
            foreach (PlayingCard card in hand)
                rep = rep + card + " ";
            return rep.Trim();
        }

        public IEnumerator<PlayingCard> GetEnumerator()
        {
            return hand.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return hand.GetEnumerator();
        }
    }
}
