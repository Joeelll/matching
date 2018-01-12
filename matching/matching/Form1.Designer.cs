namespace matching
{
    partial class MatchingGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchingGame));
            this.label1 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CardsHolder = new System.Windows.Forms.Panel();
            this.DupCard8 = new System.Windows.Forms.PictureBox();
            this.Card8 = new System.Windows.Forms.PictureBox();
            this.DupCard7 = new System.Windows.Forms.PictureBox();
            this.Card7 = new System.Windows.Forms.PictureBox();
            this.DupCard6 = new System.Windows.Forms.PictureBox();
            this.Card6 = new System.Windows.Forms.PictureBox();
            this.DupCard5 = new System.Windows.Forms.PictureBox();
            this.Card5 = new System.Windows.Forms.PictureBox();
            this.DupCard4 = new System.Windows.Forms.PictureBox();
            this.Card4 = new System.Windows.Forms.PictureBox();
            this.DupCard3 = new System.Windows.Forms.PictureBox();
            this.Card3 = new System.Windows.Forms.PictureBox();
            this.DupCard2 = new System.Windows.Forms.PictureBox();
            this.Card2 = new System.Windows.Forms.PictureBox();
            this.DupCard1 = new System.Windows.Forms.PictureBox();
            this.Card1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CardsHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(537, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score: ";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Score.Location = new System.Drawing.Point(602, 17);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(24, 25);
            this.Score.TabIndex = 2;
            this.Score.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CardsHolder
            // 
            this.CardsHolder.Controls.Add(this.DupCard8);
            this.CardsHolder.Controls.Add(this.Card8);
            this.CardsHolder.Controls.Add(this.DupCard7);
            this.CardsHolder.Controls.Add(this.Card7);
            this.CardsHolder.Controls.Add(this.DupCard6);
            this.CardsHolder.Controls.Add(this.Card6);
            this.CardsHolder.Controls.Add(this.DupCard5);
            this.CardsHolder.Controls.Add(this.Card5);
            this.CardsHolder.Controls.Add(this.DupCard4);
            this.CardsHolder.Controls.Add(this.Card4);
            this.CardsHolder.Controls.Add(this.DupCard3);
            this.CardsHolder.Controls.Add(this.Card3);
            this.CardsHolder.Controls.Add(this.DupCard2);
            this.CardsHolder.Controls.Add(this.Card2);
            this.CardsHolder.Controls.Add(this.DupCard1);
            this.CardsHolder.Controls.Add(this.Card1);
            this.CardsHolder.Location = new System.Drawing.Point(12, 15);
            this.CardsHolder.Name = "CardsHolder";
            this.CardsHolder.Size = new System.Drawing.Size(519, 394);
            this.CardsHolder.TabIndex = 3;
            // 
            // DupCard8
            // 
            this.DupCard8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DupCard8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DupCard8.BackgroundImage")));
            this.DupCard8.Image = global::matching.Properties.Resources.question;
            this.DupCard8.Location = new System.Drawing.Point(390, 291);
            this.DupCard8.Name = "DupCard8";
            this.DupCard8.Size = new System.Drawing.Size(123, 90);
            this.DupCard8.TabIndex = 21;
            this.DupCard8.TabStop = false;
            this.DupCard8.Tag = "8";
            this.DupCard8.Click += new System.EventHandler(this.DupCard8_Click);
            // 
            // Card8
            // 
            this.Card8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Card8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Card8.BackgroundImage")));
            this.Card8.Image = ((System.Drawing.Image)(resources.GetObject("Card8.Image")));
            this.Card8.Location = new System.Drawing.Point(261, 291);
            this.Card8.Name = "Card8";
            this.Card8.Size = new System.Drawing.Size(123, 90);
            this.Card8.TabIndex = 20;
            this.Card8.TabStop = false;
            this.Card8.Tag = "8";
            this.Card8.Click += new System.EventHandler(this.Card8_Click);
            // 
            // DupCard7
            // 
            this.DupCard7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DupCard7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DupCard7.BackgroundImage")));
            this.DupCard7.Image = ((System.Drawing.Image)(resources.GetObject("DupCard7.Image")));
            this.DupCard7.Location = new System.Drawing.Point(132, 291);
            this.DupCard7.Name = "DupCard7";
            this.DupCard7.Size = new System.Drawing.Size(123, 90);
            this.DupCard7.TabIndex = 19;
            this.DupCard7.TabStop = false;
            this.DupCard7.Tag = "7";
            this.DupCard7.Click += new System.EventHandler(this.DupCard7_Click);
            // 
            // Card7
            // 
            this.Card7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Card7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Card7.BackgroundImage")));
            this.Card7.Image = ((System.Drawing.Image)(resources.GetObject("Card7.Image")));
            this.Card7.Location = new System.Drawing.Point(3, 291);
            this.Card7.Name = "Card7";
            this.Card7.Size = new System.Drawing.Size(123, 90);
            this.Card7.TabIndex = 18;
            this.Card7.TabStop = false;
            this.Card7.Tag = "7";
            this.Card7.Click += new System.EventHandler(this.Card7_Click);
            // 
            // DupCard6
            // 
            this.DupCard6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DupCard6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DupCard6.BackgroundImage")));
            this.DupCard6.Image = global::matching.Properties.Resources.question;
            this.DupCard6.Location = new System.Drawing.Point(390, 195);
            this.DupCard6.Name = "DupCard6";
            this.DupCard6.Size = new System.Drawing.Size(123, 90);
            this.DupCard6.TabIndex = 15;
            this.DupCard6.TabStop = false;
            this.DupCard6.Tag = "6";
            this.DupCard6.Click += new System.EventHandler(this.DupCard6_Click);
            // 
            // Card6
            // 
            this.Card6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Card6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Card6.BackgroundImage")));
            this.Card6.Image = ((System.Drawing.Image)(resources.GetObject("Card6.Image")));
            this.Card6.Location = new System.Drawing.Point(261, 195);
            this.Card6.Name = "Card6";
            this.Card6.Size = new System.Drawing.Size(123, 90);
            this.Card6.TabIndex = 14;
            this.Card6.TabStop = false;
            this.Card6.Tag = "6";
            this.Card6.Click += new System.EventHandler(this.Card6_Click);
            // 
            // DupCard5
            // 
            this.DupCard5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DupCard5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DupCard5.BackgroundImage")));
            this.DupCard5.Image = ((System.Drawing.Image)(resources.GetObject("DupCard5.Image")));
            this.DupCard5.Location = new System.Drawing.Point(132, 195);
            this.DupCard5.Name = "DupCard5";
            this.DupCard5.Size = new System.Drawing.Size(123, 90);
            this.DupCard5.TabIndex = 13;
            this.DupCard5.TabStop = false;
            this.DupCard5.Tag = "5";
            this.DupCard5.Click += new System.EventHandler(this.DupCard5_Click);
            // 
            // Card5
            // 
            this.Card5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Card5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Card5.BackgroundImage")));
            this.Card5.Image = ((System.Drawing.Image)(resources.GetObject("Card5.Image")));
            this.Card5.Location = new System.Drawing.Point(3, 195);
            this.Card5.Name = "Card5";
            this.Card5.Size = new System.Drawing.Size(123, 90);
            this.Card5.TabIndex = 12;
            this.Card5.TabStop = false;
            this.Card5.Tag = "5";
            this.Card5.Click += new System.EventHandler(this.Card5_Click);
            // 
            // DupCard4
            // 
            this.DupCard4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DupCard4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DupCard4.BackgroundImage")));
            this.DupCard4.Image = ((System.Drawing.Image)(resources.GetObject("DupCard4.Image")));
            this.DupCard4.Location = new System.Drawing.Point(390, 99);
            this.DupCard4.Name = "DupCard4";
            this.DupCard4.Size = new System.Drawing.Size(123, 90);
            this.DupCard4.TabIndex = 9;
            this.DupCard4.TabStop = false;
            this.DupCard4.Tag = "4";
            this.DupCard4.Click += new System.EventHandler(this.DupCard4_Click);
            // 
            // Card4
            // 
            this.Card4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Card4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Card4.BackgroundImage")));
            this.Card4.Image = ((System.Drawing.Image)(resources.GetObject("Card4.Image")));
            this.Card4.Location = new System.Drawing.Point(261, 99);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(123, 90);
            this.Card4.TabIndex = 8;
            this.Card4.TabStop = false;
            this.Card4.Tag = "4";
            this.Card4.Click += new System.EventHandler(this.Card4_Click);
            // 
            // DupCard3
            // 
            this.DupCard3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DupCard3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DupCard3.BackgroundImage")));
            this.DupCard3.Image = ((System.Drawing.Image)(resources.GetObject("DupCard3.Image")));
            this.DupCard3.Location = new System.Drawing.Point(132, 99);
            this.DupCard3.Name = "DupCard3";
            this.DupCard3.Size = new System.Drawing.Size(123, 90);
            this.DupCard3.TabIndex = 7;
            this.DupCard3.TabStop = false;
            this.DupCard3.Tag = "3";
            this.DupCard3.Click += new System.EventHandler(this.DupCard3_Click);
            // 
            // Card3
            // 
            this.Card3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Card3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Card3.BackgroundImage")));
            this.Card3.Image = ((System.Drawing.Image)(resources.GetObject("Card3.Image")));
            this.Card3.Location = new System.Drawing.Point(3, 99);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(123, 90);
            this.Card3.TabIndex = 6;
            this.Card3.TabStop = false;
            this.Card3.Tag = "3";
            this.Card3.Click += new System.EventHandler(this.Card3_Click);
            // 
            // DupCard2
            // 
            this.DupCard2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DupCard2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DupCard2.BackgroundImage")));
            this.DupCard2.Image = ((System.Drawing.Image)(resources.GetObject("DupCard2.Image")));
            this.DupCard2.Location = new System.Drawing.Point(390, 3);
            this.DupCard2.Name = "DupCard2";
            this.DupCard2.Size = new System.Drawing.Size(123, 90);
            this.DupCard2.TabIndex = 3;
            this.DupCard2.TabStop = false;
            this.DupCard2.Tag = "2";
            this.DupCard2.Click += new System.EventHandler(this.DupCard2_Click);
            // 
            // Card2
            // 
            this.Card2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Card2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Card2.BackgroundImage")));
            this.Card2.Image = ((System.Drawing.Image)(resources.GetObject("Card2.Image")));
            this.Card2.Location = new System.Drawing.Point(261, 3);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(123, 90);
            this.Card2.TabIndex = 2;
            this.Card2.TabStop = false;
            this.Card2.Tag = "2";
            this.Card2.Click += new System.EventHandler(this.Card2_Click);
            // 
            // DupCard1
            // 
            this.DupCard1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.DupCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DupCard1.BackgroundImage")));
            this.DupCard1.Image = ((System.Drawing.Image)(resources.GetObject("DupCard1.Image")));
            this.DupCard1.Location = new System.Drawing.Point(132, 3);
            this.DupCard1.Name = "DupCard1";
            this.DupCard1.Size = new System.Drawing.Size(123, 90);
            this.DupCard1.TabIndex = 1;
            this.DupCard1.TabStop = false;
            this.DupCard1.Tag = "1";
            this.DupCard1.Click += new System.EventHandler(this.DupCard1_Click);
            // 
            // Card1
            // 
            this.Card1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Card1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Card1.BackgroundImage")));
            this.Card1.Image = ((System.Drawing.Image)(resources.GetObject("Card1.Image")));
            this.Card1.Location = new System.Drawing.Point(3, 3);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(123, 90);
            this.Card1.TabIndex = 0;
            this.Card1.TabStop = false;
            this.Card1.Tag = "1";
            this.Card1.Click += new System.EventHandler(this.Card1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(624, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "5";
            // 
            // timer3
            // 
            this.timer3.Interval = 250;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(551, 68);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 5;
            this.reset.Text = "Play Again";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(533, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Countdown:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MatchingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(802, 513);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CardsHolder);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MatchingGame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matching Game";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CardsHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DupCard8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DupCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel CardsHolder;
        private System.Windows.Forms.PictureBox DupCard8;
        private System.Windows.Forms.PictureBox Card8;
        private System.Windows.Forms.PictureBox DupCard7;
        private System.Windows.Forms.PictureBox Card7;
        private System.Windows.Forms.PictureBox DupCard6;
        private System.Windows.Forms.PictureBox Card6;
        private System.Windows.Forms.PictureBox DupCard5;
        private System.Windows.Forms.PictureBox Card5;
        private System.Windows.Forms.PictureBox DupCard4;
        private System.Windows.Forms.PictureBox Card4;
        private System.Windows.Forms.PictureBox DupCard3;
        private System.Windows.Forms.PictureBox Card3;
        private System.Windows.Forms.PictureBox DupCard2;
        private System.Windows.Forms.PictureBox Card2;
        private System.Windows.Forms.PictureBox DupCard1;
        private System.Windows.Forms.PictureBox Card1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label3;
    }
}

