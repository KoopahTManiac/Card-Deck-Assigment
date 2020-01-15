namespace card_deck_Assigment
{
    partial class Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NrCardsYou = new System.Windows.Forms.Label();
            this.NrCardsPC = new System.Windows.Forms.Label();
            this.PcCardC = new System.Windows.Forms.PictureBox();
            this.playerCardC = new System.Windows.Forms.PictureBox();
            this.cardDeck = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.WinnerLBL = new System.Windows.Forms.Label();
            this.WinnerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PcCardC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "You did Draw";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PC did Draw";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount Of Cards";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(654, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount Of Cards";
            // 
            // NrCardsYou
            // 
            this.NrCardsYou.AutoSize = true;
            this.NrCardsYou.Location = new System.Drawing.Point(77, 54);
            this.NrCardsYou.Name = "NrCardsYou";
            this.NrCardsYou.Size = new System.Drawing.Size(13, 13);
            this.NrCardsYou.TabIndex = 6;
            this.NrCardsYou.Text = "0";
            // 
            // NrCardsPC
            // 
            this.NrCardsPC.AutoSize = true;
            this.NrCardsPC.Location = new System.Drawing.Point(691, 54);
            this.NrCardsPC.Name = "NrCardsPC";
            this.NrCardsPC.Size = new System.Drawing.Size(13, 13);
            this.NrCardsPC.TabIndex = 7;
            this.NrCardsPC.Text = "0";
            // 
            // PcCardC
            // 
            this.PcCardC.Location = new System.Drawing.Point(411, 81);
            this.PcCardC.Name = "PcCardC";
            this.PcCardC.Size = new System.Drawing.Size(145, 200);
            this.PcCardC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcCardC.TabIndex = 1;
            this.PcCardC.TabStop = false;
            // 
            // playerCardC
            // 
            this.playerCardC.Location = new System.Drawing.Point(226, 81);
            this.playerCardC.Name = "playerCardC";
            this.playerCardC.Size = new System.Drawing.Size(145, 200);
            this.playerCardC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerCardC.TabIndex = 0;
            this.playerCardC.TabStop = false;
            // 
            // cardDeck
            // 
            this.cardDeck.AccessibleName = "CardDeck";
            this.cardDeck.Image = global::card_deck_Assigment.Properties.Resources.back;
            this.cardDeck.Location = new System.Drawing.Point(626, 81);
            this.cardDeck.Name = "cardDeck";
            this.cardDeck.Size = new System.Drawing.Size(145, 200);
            this.cardDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cardDeck.TabIndex = 9;
            this.cardDeck.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.AccessibleName = "CardDeck";
            this.pictureBox4.Image = global::card_deck_Assigment.Properties.Resources.back;
            this.pictureBox4.Location = new System.Drawing.Point(12, 81);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(145, 200);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "First One to have zero cards left wins";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Draw Card Here";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Who has highest card gets booth cards";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Draw leads in the cards being discarded";
            // 
            // WinnerLBL
            // 
            this.WinnerLBL.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.WinnerLBL.Location = new System.Drawing.Point(341, 22);
            this.WinnerLBL.Name = "WinnerLBL";
            this.WinnerLBL.Size = new System.Drawing.Size(100, 23);
            this.WinnerLBL.TabIndex = 15;
            this.WinnerLBL.Text = "Winner Is";
            this.WinnerLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WinnerLBL.Visible = false;
            // 
            // WinnerName
            // 
            this.WinnerName.ForeColor = System.Drawing.Color.Red;
            this.WinnerName.Location = new System.Drawing.Point(341, 41);
            this.WinnerName.Name = "WinnerName";
            this.WinnerName.Size = new System.Drawing.Size(100, 23);
            this.WinnerName.TabIndex = 16;
            this.WinnerName.Text = "PC";
            this.WinnerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WinnerName.Visible = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(27)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(783, 353);
            this.Controls.Add(this.WinnerName);
            this.Controls.Add(this.WinnerLBL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.cardDeck);
            this.Controls.Add(this.NrCardsPC);
            this.Controls.Add(this.NrCardsYou);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PcCardC);
            this.Controls.Add(this.playerCardC);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Game";
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.PcCardC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerCardC;
        private System.Windows.Forms.PictureBox PcCardC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NrCardsYou;
        private System.Windows.Forms.Label NrCardsPC;
        private System.Windows.Forms.PictureBox cardDeck;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label WinnerLBL;
        private System.Windows.Forms.Label WinnerName;
    }
}