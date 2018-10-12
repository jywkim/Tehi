﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardLib;

namespace Tehi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DealButton_Click(object sender, EventArgs e)
        {
            LogListBox.Items.Clear();            PlayingCard card = new PlayingCard(PlayingCard.Queen, CardSuit.Clubs);            card.Flip();            LogListBox.Items.Add("Card: " + card);
            LogListBox.Items.Add("Rank: " + card.Rank);            LogListBox.Items.Add("Suit: " + card.Suit);            StatusLabel.Text = "Deal button pressed";        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogListBox.Items.Clear();
            StatusLabel.Text = string.Empty;
        }

        private void top10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Top 10 chosen";        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Jonathan Kim");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Login button pressed";        }

        private void SwapCard(int ix)
        {
            StatusLabel.Text = "Swap button " + ix + " pressed.";
        }

        private void SwapButton0_Click(object sender, EventArgs e)
        {
            SwapCard(0);
        }

        private void SwapButton1_Click(object sender, EventArgs e)
        {
            SwapCard(1);
        }

        private void SwapButton2_Click(object sender, EventArgs e)
        {
            SwapCard(2);
        }

        private void SwapButton3_Click(object sender, EventArgs e)
        {
            SwapCard(3);
        }

        private void SwapButton4_Click(object sender, EventArgs e)
        {
            SwapCard(4);
        }

        private void tableColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog(this);
            if (result == DialogResult.Cancel) return;
            BackColor = colorDialog1.Color;
        }

        private void resetDefaultColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }
    }
}
