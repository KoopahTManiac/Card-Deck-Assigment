using card_deck_Assigment.Cards;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Card_Deck_Unit_Test
{
    [TestClass]

    public class TestCardGame
    {
        [TestMethod]
        public void DeckDrawTest()
        {
            //Init Deck
            Deck mDeck = new Deck();
            //Draw All Cards
            int nrCardsToDraw = 52;

            //Iterate trugh the amount of cards that need to be drawn and check that it returns a none null value also check if the card is drawn(Removed from the list)
            for(int i= 0; i < nrCardsToDraw; i++)
            {
                Assert.IsNotNull(mDeck.DrawTopCard());
                Assert.IsTrue(mDeck.GetNrOfCards() < nrCardsToDraw - i);
            }

            //check if we did draw all the cards in the deck
            Assert.IsTrue(mDeck.GetNrOfCards() == 0);

            //check what happens if we try to draw more cards then there are in the deck
            try
            {
                mDeck.DrawTopCard();
                throw new AssertFailedException("Should not be posible");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "No Cards Are left");
            }
        }

        [TestMethod]

        public void DeckShuffleTest()
        {
            //make a new deck of sorted cards
            Deck mDeck = new Deck();
            Deck mRefDeck = new Deck();
            mDeck.Shuffle();

            //check if Shuffle Works by first setting the bool to true then checking trugh the deck to see if there are diferences
            bool shuffleSame = true;
            for (int i = 0; i < mDeck.GetNrOfCards(); i++)
            {
                Card mCard = mDeck.DrawTopCard();
                Card mRefCard = mDeck.DrawTopCard();
                if ((!mCard.mColor.Equals(mRefCard.mColor) || !mCard.mType.Equals(mRefCard.mType) || !mCard.mValue.Equals(mRefCard.mValue)))
                {
                    shuffleSame = false;
                }
            }
            //Should be false if shuffle is working
            Assert.IsFalse(shuffleSame);

        }

        [TestMethod]
        public void DeckSortTest()
        {
            //make a new deck of sorted cards
            Deck mDeck = new Deck();
            Deck mRefDeck = new Deck();
            mDeck.Shuffle();

            //check if Shuffle Works by first setting the bool to true then checking trugh the deck to see if there are diferences
            bool shuffleSame = true;
            for (int i = 0; i < mDeck.GetNrOfCards(); i++)
            {
                Card mCard = mDeck.DrawTopCard();
                Card mRefCard = mDeck.DrawTopCard();
                if ((!mCard.mColor.Equals(mRefCard.mColor) || !mCard.mType.Equals(mRefCard.mType) || !mCard.mValue.Equals(mRefCard.mValue)))
                {
                    shuffleSame = false;
                }
            }
            //Should be false if shuffle is working
            Assert.IsFalse(shuffleSame);

            //since the cards are drawn re init Booth decks and reshuffle
            mDeck = new Deck();
            mRefDeck = new Deck();
            mDeck.Shuffle();

            //now test if sorting works, if it does then the cards should end in same order
            mDeck.Sort();
            bool sortSame = true;
            for (int i = 0; i < mDeck.GetNrOfCards(); i++)
            {
                Card mCard = mDeck.DrawTopCard();
                Card mRefCard = mRefDeck.DrawTopCard();
                //Test if all cards are the same if they are then the cards are sorted
                if (!(mCard.mColor.Equals(mRefCard.mColor) && mCard.mType.Equals(mRefCard.mType) && mCard.mValue.Equals(mRefCard.mValue)))
                {
                    sortSame = false;
                }
            }
            //Test Result of sort
            Assert.IsTrue(sortSame);
        }
    }
}
