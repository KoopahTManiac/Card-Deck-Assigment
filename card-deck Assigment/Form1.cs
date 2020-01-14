using card_deck_Assigment.Properties;
using card_deck_assignment.Cards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace card_deck_Assigment
{
    public partial class Form1 : Form
    {
        Deck mDeck = new Deck();
        PictureBox currentCard = new PictureBox();

        public Form1()
        {
            init();
            InitializeComponent();
        }

        //init the Image holder to display the current card that is drawn
        private void init()
        {
            currentCard.Size = new Size(145, 200);
            currentCard.Location = new Point(16, 50);
            currentCard.SizeMode = PictureBoxSizeMode.Zoom;
            this.Controls.Add(currentCard);
        }

        //Grab a card from the deck and display it
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(mDeck.GetNrOfCards() >0)
            {
                Card mCard = mDeck.DrawTopCard();
                displayCard(mCard);
            }
            else
            {
                cardDeck.Visible = false;
            }
            
        }

        //display the card
        private void displayCard(Card mCard)
        {
            Image myImage = (Image)Resources.ResourceManager.GetObject(mCard.mImage);
            currentCard.Image = myImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //A new Deck
        private void newDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mDeck = new Deck();
            cardDeck.Visible = true;
        }

        //Shuffle the deck
        private void shuffleDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mDeck.Shuffle();
        }
        //Sort the deck
        private void sortDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mDeck.Sort();
        }
    }
}
