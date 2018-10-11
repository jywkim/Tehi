using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            LogListBox.Items.Clear();            LogListBox.Items.Add("The spade symbol is \u2660");            StatusLabel.Text = "Deal button pressed";        }

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
    }
}
