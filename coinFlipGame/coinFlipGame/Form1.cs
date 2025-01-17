﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coinFlipGame
{
    public partial class coinFlipGame : Form
    {
        int heads = 0;
        int tails = 0;

        public coinFlipGame()
        {
            InitializeComponent();
        }

        private void coinFlipButton_Click(object sender, EventArgs e)
        {
            Random coinFlip = new Random();
            int result = coinFlip.Next(1, 3);

            //The result is heads
            if (result == 1)
            {
                coinImage.ImageLocation = @"C:\Users\shann\OneDrive - Broward College\CSharp\coinFlipGame\coinFlipGame\images\Heads1.bmp";
                coinImage.SizeMode = PictureBoxSizeMode.StretchImage;
                heads++;
                headsLabel.Text = "Heads: " + heads.ToString();
            }

            //The result is tails
            else
            {
                coinImage.ImageLocation = @"C:\Users\shann\OneDrive - Broward College\CSharp\coinFlipGame\coinFlipGame\images\Tails1.bmp";
                coinImage.SizeMode = PictureBoxSizeMode.StretchImage;
                tails++;
                tailsLabel.Text = "Tails: " + tails.ToString();

            }

        }
    }
}
