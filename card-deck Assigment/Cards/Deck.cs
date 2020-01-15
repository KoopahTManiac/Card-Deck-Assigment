using System;
using System.Collections.Generic;
using System.Text;

namespace card_deck_Assigment.Cards
{
    public class Deck
    {

        List<Card> mCards = new List<Card>();
        public Deck(List<Card> cards)
        {
            mCards = cards;
        }
        public Deck()
        {
            foreach (CType ctype in (CType[])Enum.GetValues(typeof(CType)))
            {
                foreach (CValue cvalue in (CValue[])Enum.GetValues(typeof(CValue)))
                {
                    mCards.Add(new Card(ctype, cvalue));
                }
            }
        }
        //Get the top card and then remove it from the list
        public Card DrawTopCard()
        {
            if(mCards.Count > 0)
            {
                Card card = mCards[mCards.Count-1];
                mCards.RemoveAt(mCards.Count-1);
                return card;
            }
            throw new Exception("No Cards Are left");
        }

        //Get the bottom card and then remove it from the list
        public Card DrawBottomCard()
        {
            if (mCards.Count > 0)
            {
                Card card = mCards[0];
                mCards.RemoveAt(0);
                return card;
            }
            throw new Exception("No Cards Are left");
        }

        //Sort the Deck by the CompareTo method in the Card Class
        public void Sort()
        {
            mCards.Sort();
        }

        public void Shuffle()
        {
            Random random = new Random();
            //Shuffle a card randomly from all the cards into n spot from last to Secound Card since first card will be swaped by secound
            //then decrease the randome limit by one for each loop
            
            for(int n= mCards.Count-1; n > 1; n--)
            {
                int k = random.Next(n+1);
                //store the card for swaping temporarly
                Card card = mCards[k];
                mCards[k] = mCards[n];
                //now assign it to the n spot
                mCards[n] = card;
            }
        }

        public void Shuffle(Random seed)
        {
            Random random = seed;
            //Shuffle a card randomly from all the cards into n spot from last to Secound Card since first card will be swaped by secound
            //then decrease the randome limit by one for each loop

            for (int n = mCards.Count - 1; n > 1; n--)
            {
                int k = random.Next(n + 1);
                //store the card for swaping temporarly
                Card card = mCards[k];
                mCards[k] = mCards[n];
                //now assign it to the n spot
                mCards[n] = card;
            }
        }

        //Print all the cards as string representation of the enums in short color name and value like {Red Heart Ace}
        public string toString()
        {
            String returnS = "";
            foreach (Card card in mCards)
            {
                returnS += "{" + card.mColor.ToString() + " " + card.mType.ToString() + " " + card.mValue.ToString() + "}";
            }
            return returnS;
        }

        //Return number of cards in the deck
        public int GetNrOfCards()
        {
            return mCards.Count;
        }

        public void AddCard(Card card)
        {
            mCards.Add(card);
        }

    }
}
