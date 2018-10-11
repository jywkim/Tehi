namespace Tehi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LogListBox = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DealButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SwapButton0 = new System.Windows.Forms.Button();
            this.SwapButton4 = new System.Windows.Forms.Button();
            this.SwapButton3 = new System.Windows.Forms.Button();
            this.SwapButton2 = new System.Windows.Forms.Button();
            this.SwapButton1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.resetDefaultColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogListBox
            // 
            this.LogListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogListBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogListBox.FormattingEnabled = true;
            this.LogListBox.HorizontalScrollbar = true;
            this.LogListBox.ItemHeight = 16;
            this.LogListBox.Location = new System.Drawing.Point(115, 43);
            this.LogListBox.Name = "LogListBox";
            this.LogListBox.Size = new System.Drawing.Size(162, 36);
            this.LogListBox.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(649, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // DealButton
            // 
            this.DealButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DealButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealButton.Location = new System.Drawing.Point(308, 171);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(96, 32);
            this.DealButton.TabIndex = 2;
            this.DealButton.Text = "Deal";
            this.DealButton.UseVisualStyleBackColor = true;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.top10ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // top10ToolStripMenuItem
            // 
            this.top10ToolStripMenuItem.Name = "top10ToolStripMenuItem";
            this.top10ToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.top10ToolStripMenuItem.Text = "&Top 10";
            this.top10ToolStripMenuItem.Click += new System.EventHandler(this.top10ToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableColourToolStripMenuItem,
            this.resetDefaultColorToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "&Preferences";
            // 
            // tableColourToolStripMenuItem
            // 
            this.tableColourToolStripMenuItem.Name = "tableColourToolStripMenuItem";
            this.tableColourToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tableColourToolStripMenuItem.Text = "&Table Colour";
            this.tableColourToolStripMenuItem.Click += new System.EventHandler(this.tableColourToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(115, 171);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(73, 26);
            this.NameTextBox.TabIndex = 4;
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(206, 171);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(96, 32);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SwapButton0
            // 
            this.SwapButton0.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SwapButton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwapButton0.Location = new System.Drawing.Point(115, 122);
            this.SwapButton0.Name = "SwapButton0";
            this.SwapButton0.Size = new System.Drawing.Size(96, 32);
            this.SwapButton0.TabIndex = 6;
            this.SwapButton0.Text = "Swap";
            this.SwapButton0.UseVisualStyleBackColor = true;
            this.SwapButton0.Click += new System.EventHandler(this.SwapButton0_Click);
            // 
            // SwapButton4
            // 
            this.SwapButton4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SwapButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwapButton4.Location = new System.Drawing.Point(523, 122);
            this.SwapButton4.Name = "SwapButton4";
            this.SwapButton4.Size = new System.Drawing.Size(96, 32);
            this.SwapButton4.TabIndex = 7;
            this.SwapButton4.Text = "Swap";
            this.SwapButton4.UseVisualStyleBackColor = true;
            this.SwapButton4.Click += new System.EventHandler(this.SwapButton4_Click);
            // 
            // SwapButton3
            // 
            this.SwapButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SwapButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwapButton3.Location = new System.Drawing.Point(421, 122);
            this.SwapButton3.Name = "SwapButton3";
            this.SwapButton3.Size = new System.Drawing.Size(96, 32);
            this.SwapButton3.TabIndex = 8;
            this.SwapButton3.Text = "Swap";
            this.SwapButton3.UseVisualStyleBackColor = true;
            this.SwapButton3.Click += new System.EventHandler(this.SwapButton3_Click);
            // 
            // SwapButton2
            // 
            this.SwapButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SwapButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwapButton2.Location = new System.Drawing.Point(319, 122);
            this.SwapButton2.Name = "SwapButton2";
            this.SwapButton2.Size = new System.Drawing.Size(96, 32);
            this.SwapButton2.TabIndex = 9;
            this.SwapButton2.Text = "Swap";
            this.SwapButton2.UseVisualStyleBackColor = true;
            this.SwapButton2.Click += new System.EventHandler(this.SwapButton2_Click);
            // 
            // SwapButton1
            // 
            this.SwapButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SwapButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwapButton1.Location = new System.Drawing.Point(217, 122);
            this.SwapButton1.Name = "SwapButton1";
            this.SwapButton1.Size = new System.Drawing.Size(96, 32);
            this.SwapButton1.TabIndex = 10;
            this.SwapButton1.Text = "Swap";
            this.SwapButton1.UseVisualStyleBackColor = true;
            this.SwapButton1.Click += new System.EventHandler(this.SwapButton1_Click);
            // 
            // resetDefaultColorToolStripMenuItem
            // 
            this.resetDefaultColorToolStripMenuItem.Name = "resetDefaultColorToolStripMenuItem";
            this.resetDefaultColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetDefaultColorToolStripMenuItem.Text = "Reset Default Color";
            this.resetDefaultColorToolStripMenuItem.Click += new System.EventHandler(this.resetDefaultColorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(649, 381);
            this.Controls.Add(this.SwapButton1);
            this.Controls.Add(this.SwapButton2);
            this.Controls.Add(this.SwapButton3);
            this.Controls.Add(this.SwapButton4);
            this.Controls.Add(this.SwapButton0);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.DealButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LogListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Eyes Have It!";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LogListBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Button DealButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button SwapButton0;
        private System.Windows.Forms.Button SwapButton4;
        private System.Windows.Forms.Button SwapButton3;
        private System.Windows.Forms.Button SwapButton2;
        private System.Windows.Forms.Button SwapButton1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem resetDefaultColorToolStripMenuItem;
    }
}

