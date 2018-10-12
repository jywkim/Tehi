﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLib
{
    public class CardDeck
    {
        private Stack<PlayingCard> cardStack = new Stack<PlayingCard>();

        public CardDeck()
        {
            Array suitChoices = Enum.GetValues(typeof(CardSuit));
            foreach (CardSuit s in suitChoices)
            {
                for (int r = PlayingCard.Ace; r <= PlayingCard.King; r ++)
                {
                    PlayingCard card;
                    if (r < PlayingCard.Jack) card = new PlayingCard(r, s);
                    else card = new FaceCard(r, s);
                    card.FaceUp = true;
                    cardStack.Push(card);
                }
            }
        }
    }
}