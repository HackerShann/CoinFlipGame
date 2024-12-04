namespace coinFlipGame
{
    partial class coinFlipGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(coinFlipGame));
            this.coinImage = new System.Windows.Forms.PictureBox();
            this.coinFlipButton = new System.Windows.Forms.Button();
            this.headsLabel = new System.Windows.Forms.Label();
            this.tailsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coinImage)).BeginInit();
            this.SuspendLayout();
            // 
            // coinImage
            // 
            this.coinImage.Image = ((System.Drawing.Image)(resources.GetObject("coinImage.Image")));
            this.coinImage.Location = new System.Drawing.Point(262, 41);
            this.coinImage.Name = "coinImage";
            this.coinImage.Size = new System.Drawing.Size(550, 543);
            this.coinImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coinImage.TabIndex = 0;
            this.coinImage.TabStop = false;
            // 
            // coinFlipButton
            // 
            this.coinFlipButton.BackColor = System.Drawing.SystemColors.Window;
            this.coinFlipButton.Font = new System.Drawing.Font("Yu-Gi-Oh! Matrix Book", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinFlipButton.Location = new System.Drawing.Point(262, 709);
            this.coinFlipButton.Name = "coinFlipButton";
            this.coinFlipButton.Size = new System.Drawing.Size(550, 104);
            this.coinFlipButton.TabIndex = 1;
            this.coinFlipButton.Text = "Flip";
            this.coinFlipButton.UseVisualStyleBackColor = false;
            this.coinFlipButton.Click += new System.EventHandler(this.coinFlipButton_Click);
            // 
            // headsLabel
            // 
            this.headsLabel.BackColor = System.Drawing.SystemColors.Window;
            this.headsLabel.Font = new System.Drawing.Font("Yu-Gi-Oh! Matrix Book", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headsLabel.Location = new System.Drawing.Point(262, 607);
            this.headsLabel.Name = "headsLabel";
            this.headsLabel.Size = new System.Drawing.Size(265, 80);
            this.headsLabel.TabIndex = 2;
            this.headsLabel.Text = "Heads:";
            this.headsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tailsLabel
            // 
            this.tailsLabel.BackColor = System.Drawing.SystemColors.Window;
            this.tailsLabel.Font = new System.Drawing.Font("Yu-Gi-Oh! Matrix Book", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tailsLabel.Location = new System.Drawing.Point(546, 607);
            this.tailsLabel.Name = "tailsLabel";
            this.tailsLabel.Size = new System.Drawing.Size(266, 80);
            this.tailsLabel.TabIndex = 3;
            this.tailsLabel.Text = "Tails:";
            this.tailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coinFlipGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1115, 825);
            this.Controls.Add(this.tailsLabel);
            this.Controls.Add(this.headsLabel);
            this.Controls.Add(this.coinFlipButton);
            this.Controls.Add(this.coinImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "coinFlipGame";
            this.Text = "coinFlipGame";
            ((System.ComponentModel.ISupportInitialize)(this.coinImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox coinImage;
        private System.Windows.Forms.Button coinFlipButton;
        private System.Windows.Forms.Label headsLabel;
        private System.Windows.Forms.Label tailsLabel;
    }
}

