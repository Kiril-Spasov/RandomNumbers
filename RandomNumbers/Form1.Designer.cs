namespace RandomNumbers
{
    partial class FormRandomNumbers
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
            this.TxtText = new System.Windows.Forms.TextBox();
            this.BtnCoinToss = new System.Windows.Forms.Button();
            this.Btn4CoinsToss = new System.Windows.Forms.Button();
            this.BtnDiceCounter = new System.Windows.Forms.Button();
            this.BtnDiceWordsGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtText
            // 
            this.TxtText.Location = new System.Drawing.Point(463, 55);
            this.TxtText.Multiline = true;
            this.TxtText.Name = "TxtText";
            this.TxtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtText.Size = new System.Drawing.Size(265, 315);
            this.TxtText.TabIndex = 1;
            // 
            // BtnCoinToss
            // 
            this.BtnCoinToss.Location = new System.Drawing.Point(57, 45);
            this.BtnCoinToss.Name = "BtnCoinToss";
            this.BtnCoinToss.Size = new System.Drawing.Size(187, 43);
            this.BtnCoinToss.TabIndex = 3;
            this.BtnCoinToss.Text = "Coin Toss";
            this.BtnCoinToss.UseVisualStyleBackColor = true;
            this.BtnCoinToss.Click += new System.EventHandler(this.BtnCoinToss_Click);
            // 
            // Btn4CoinsToss
            // 
            this.Btn4CoinsToss.Location = new System.Drawing.Point(55, 94);
            this.Btn4CoinsToss.Name = "Btn4CoinsToss";
            this.Btn4CoinsToss.Size = new System.Drawing.Size(186, 42);
            this.Btn4CoinsToss.TabIndex = 4;
            this.Btn4CoinsToss.Text = "4 Coins Toss";
            this.Btn4CoinsToss.UseVisualStyleBackColor = true;
            this.Btn4CoinsToss.Click += new System.EventHandler(this.Btn4CoinsToss_Click);
            // 
            // BtnDiceCounter
            // 
            this.BtnDiceCounter.Location = new System.Drawing.Point(57, 142);
            this.BtnDiceCounter.Name = "BtnDiceCounter";
            this.BtnDiceCounter.Size = new System.Drawing.Size(184, 41);
            this.BtnDiceCounter.TabIndex = 5;
            this.BtnDiceCounter.Text = "Dice Counter";
            this.BtnDiceCounter.UseVisualStyleBackColor = true;
            this.BtnDiceCounter.Click += new System.EventHandler(this.BtnDiceCounter_Click);
            // 
            // BtnDiceWordsGame
            // 
            this.BtnDiceWordsGame.Location = new System.Drawing.Point(55, 189);
            this.BtnDiceWordsGame.Name = "BtnDiceWordsGame";
            this.BtnDiceWordsGame.Size = new System.Drawing.Size(184, 41);
            this.BtnDiceWordsGame.TabIndex = 6;
            this.BtnDiceWordsGame.Text = "Dice Words Game";
            this.BtnDiceWordsGame.UseVisualStyleBackColor = true;
            this.BtnDiceWordsGame.Click += new System.EventHandler(this.BtnDiceWordsGame_Click);
            // 
            // FormRandomNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDiceWordsGame);
            this.Controls.Add(this.BtnDiceCounter);
            this.Controls.Add(this.Btn4CoinsToss);
            this.Controls.Add(this.BtnCoinToss);
            this.Controls.Add(this.TxtText);
            this.Name = "FormRandomNumbers";
            this.Text = "Random Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtText;
        private System.Windows.Forms.Button BtnCoinToss;
        private System.Windows.Forms.Button Btn4CoinsToss;
        private System.Windows.Forms.Button BtnDiceCounter;
        private System.Windows.Forms.Button BtnDiceWordsGame;
    }
}

