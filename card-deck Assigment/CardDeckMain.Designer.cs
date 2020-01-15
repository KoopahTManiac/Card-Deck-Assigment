namespace card_deck_Assigment
{
    partial class CardDeckMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cardDeck = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shuffleDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.playAGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.cardDeck)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardDeck
            // 
            this.cardDeck.AccessibleName = "CardDeck";
            this.cardDeck.Image = global::card_deck_Assigment.Properties.Resources.back;
            this.cardDeck.Location = new System.Drawing.Point(400, 50);
            this.cardDeck.Name = "cardDeck";
            this.cardDeck.Size = new System.Drawing.Size(145, 200);
            this.cardDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardDeck.TabIndex = 0;
            this.cardDeck.TabStop = false;
            this.cardDeck.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDeckToolStripMenuItem,
            this.shuffleDeckToolStripMenuItem,
            this.sortDeckToolStripMenuItem,
            this.playAGameToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newDeckToolStripMenuItem
            // 
            this.newDeckToolStripMenuItem.Name = "newDeckToolStripMenuItem";
            this.newDeckToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newDeckToolStripMenuItem.Text = "New Deck";
            this.newDeckToolStripMenuItem.Click += new System.EventHandler(this.newDeckToolStripMenuItem_Click);
            // 
            // shuffleDeckToolStripMenuItem
            // 
            this.shuffleDeckToolStripMenuItem.Name = "shuffleDeckToolStripMenuItem";
            this.shuffleDeckToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shuffleDeckToolStripMenuItem.Text = "Shuffle Deck";
            this.shuffleDeckToolStripMenuItem.Click += new System.EventHandler(this.shuffleDeckToolStripMenuItem_Click);
            // 
            // sortDeckToolStripMenuItem
            // 
            this.sortDeckToolStripMenuItem.Name = "sortDeckToolStripMenuItem";
            this.sortDeckToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sortDeckToolStripMenuItem.Text = "Sort Deck";
            this.sortDeckToolStripMenuItem.Click += new System.EventHandler(this.sortDeckToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Click Bellow to Grab Card";
            // 
            // playAGameToolStripMenuItem
            // 
            this.playAGameToolStripMenuItem.Name = "playAGameToolStripMenuItem";
            this.playAGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playAGameToolStripMenuItem.Text = "Play A Game";
            this.playAGameToolStripMenuItem.Click += new System.EventHandler(this.playAGameToolStripMenuItem_Click);
            // 
            // CardDeckMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(570, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cardDeck);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CardDeckMain";
            this.Text = "Card Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardDeck)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cardDeck;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDeckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shuffleDeckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortDeckToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem playAGameToolStripMenuItem;
    }
}

