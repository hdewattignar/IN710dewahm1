﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BridgeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Game game = new Game();

        private void playButton_Click(object sender, EventArgs e)
        {
            game.PlayGame();

            string displayString = game.DisplayHands();

            cardDisplay.Text = displayString;
        }
    }
}
