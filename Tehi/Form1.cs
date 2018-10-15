using System;
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
        private TehiGame game = new TehiGame();

        public Form1()
        {
            InitializeComponent();
        }

        private void DealButton_Click(object sender, EventArgs e)
        {
            LogListBox.Items.Clear();
            game.Deal();
            ShowOutput();
        }

        private void ShowOutput()
        {
            LogListBox.Items.Clear();
            foreach (PlayingCard c in game)
            {
                LogListBox.Items.Add(c.ToString());
            }
            PictureBox[] images = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
            for (int i = 0; i < game.Count(); i++)
            {
                PaintCard(images[i], game.ElementAt(i));
            }
            LogListBox.Items.Add(game.ToString());
            LogListBox.Items.Add("Score: " + game.Score);
            LogListBox.Items.Add("Best Hand Score: " + game.BestHandScore);
            LogListBox.Items.Add("Hands Dealt: " + game.HandsDealt);
        }

        private void PaintCard(PictureBox image, PlayingCard card)
        {
            image.Visible = true;
            int ix = card.Index;
            image.Image = PlayingCardImageList.Images[ix];
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogListBox.Items.Clear();
            StatusLabel.Text = string.Empty;
            game = new TehiGame();
        }

        private void top10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Top 10 chosen";
        }

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
            StatusLabel.Text = "Login button pressed";
        }

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
