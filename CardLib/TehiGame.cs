using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public class TehiGame
    {
        private CardDeck deck = new CardDeck();        List<PlayingCard> hand = new List<PlayingCard>();        public void Deal()        {
            foreach (PlayingCard card in hand) deck.Add(card);
            hand.Clear();
            deck.Shuffle();
            for (int i = 0; i < 5; i++)
            {
                PlayingCard card = deck.Deal();
                card.FaceUp = true;
                hand.Add(card);
            }
        }        public override string ToString()
        {
            string rep = string.Empty;
            foreach (PlayingCard card in hand)
                rep = rep + card + " ";
            return rep.Trim();
        }    }
}
