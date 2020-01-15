using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using card_deck_Assigment.Cards;
using card_deck_Assigment.Properties;

namespace card_deck_Assigment
{
    public partial class Game : Form
    {
        Deck mDeck = new Deck();
        Deck mPcDeck = new Deck();
        public Game()
        {
            mDeck.Shuffle(new Random(new Random().Next()));
            mPcDeck.Shuffle();
            InitializeComponent();
            NrCardsPC.Text = mPcDeck.GetNrOfCards().ToString();
            NrCardsYou.Text = mDeck.GetNrOfCards().ToString();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //Runs main Game Logic
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (mDeck.GetNrOfCards() > 0 && mPcDeck.GetNrOfCards() >0)
            {
                //draw a card from each deck
                Card mCard = mDeck.DrawTopCard();
                Card mPcCard = mPcDeck.DrawTopCard();
                //Display the cards
                displayCard(mCard);
                displayPcCard(mPcCard);

                //if player has highest card then add the cards to players deck
                if(mCard.mValue > mPcCard.mValue)
                {
                    mDeck.AddCard(mCard);
                    mDeck.AddCard(mPcCard);
                    mDeck.Shuffle(new Random(new Random().Next()));
                    
                    NrCardsYou.Text = mDeck.GetNrOfCards().ToString();
                    NrCardsPC.Text = mPcDeck.GetNrOfCards().ToString();
                    WinnerName.Text = "Player Gets Cards";
                    WinnerName.Visible = true;
                }
                //if pc has highest card then add the cards to the pc deck
                else if (mCard.mValue < mPcCard.mValue)
                {
                    mPcDeck.AddCard(mCard);
                    mPcDeck.AddCard(mPcCard);
                    mPcDeck.Shuffle();
                    NrCardsYou.Text = mDeck.GetNrOfCards().ToString();
                    NrCardsPC.Text = mPcDeck.GetNrOfCards().ToString();
                    WinnerName.Text = "PC Gets Cards";
                    WinnerName.Visible = true;
                }
                //draw so discard booth of the cards
                else
                {
                    WinnerName.Text = "Draw";
                    WinnerName.Visible = true;
                    NrCardsYou.Text = mDeck.GetNrOfCards().ToString();
                    NrCardsPC.Text = mPcDeck.GetNrOfCards().ToString();
                }

            }
            else
            {
                //we have a winner so show the winner
                DisplayWinnerScreen();
            }
        }

        //update the displayed card for user
        private void displayCard(Card mCard)
        {
            Image myImage = (Image)Resources.ResourceManager.GetObject(mCard.mImage);
            playerCardC.Image = myImage;
        }
        //update the displayed card for PC
        private void displayPcCard(Card mCard)
        {
            Image myImage = (Image)Resources.ResourceManager.GetObject(mCard.mImage);
            PcCardC.Image = myImage;
        }


        //display who won the game
        private void DisplayWinnerScreen()
        {
            //if player has less cards then pc, then player wins
            if(mDeck.GetNrOfCards() < mPcDeck.GetNrOfCards())
            {
                WinnerName.Text = "Player Wins";
                WinnerName.Visible = true;
                WinnerLBL.Visible = true;
            }
            else //if player has more cards or if draw then pc wins
            {
                WinnerName.Text = "PC Wins";
                WinnerName.Visible = true;
                WinnerLBL.Visible = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
