using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matching
{
    public partial class MatchingGame : Form
    {
        int score = 0;
        Random Location = new Random();
        List<Point> points = new List<Point>();
        bool again = false;
        PictureBox PendingImage1;
        PictureBox PendingImage2;

        public MatchingGame()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            
            t.Start();
            Thread.Sleep(5000);
            t.Abort();
            InitializeComponent();
        }

        public void SplashStart()
        {
            Application.Run(new Form2());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Countdown:";
            label2.Text = "5";
            Score.Text = "0";
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                int next = Location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }

            timer2.Start();
            timer1.Start();
            Card1.Image = Properties.Resources.Card1;
            DupCard1.Image = Properties.Resources.Card1;
            Card2.Image = Properties.Resources.Card2;
            DupCard2.Image = Properties.Resources.Card2;
            Card3.Image = Properties.Resources.Card3;
            DupCard3.Image = Properties.Resources.Card3;
            Card4.Image = Properties.Resources.Card4;
            DupCard4.Image = Properties.Resources.Card4;
            Card5.Image = Properties.Resources.Card5;
            DupCard5.Image = Properties.Resources.Card5;
            Card6.Image = Properties.Resources.Card6;
            DupCard6.Image = Properties.Resources.Card6;
            Card7.Image = Properties.Resources.Card7;
            DupCard7.Image = Properties.Resources.Card7;
            Card8.Image = Properties.Resources.Card8;
            DupCard8.Image = Properties.Resources.Card8;          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = null;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label2.Text);
            timer = timer-1;
            label2.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer2.Stop();
                label2.Text = "";
                label3.Text = "";
            }
           
        }

        #region Cards
        private void Card1_Click(object sender, EventArgs e)
        {

            compare(Card1, DupCard1);
            Card1.Image = Properties.Resources.Card1;
        }

        private void DupCard1_Click(object sender, EventArgs e)
        {
            
            compare(DupCard1, Card1);
            DupCard1.Image = Properties.Resources.Card1;
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            
            compare(Card2, DupCard2);
            Card2.Image = Properties.Resources.Card2;
        }

        private void DupCard2_Click(object sender, EventArgs e)
        {
            
            compare(DupCard2, Card2);
            DupCard2.Image = Properties.Resources.Card2;
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            Card3.Image = Properties.Resources.Card3;
            compare(Card3, DupCard3);
        }

        private void DupCard3_Click(object sender, EventArgs e)
        {
            DupCard3.Image = Properties.Resources.Card3;
            compare(DupCard3, Card3);
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            Card4.Image = Properties.Resources.Card4;
            compare(Card4, DupCard4);
        }

        private void DupCard4_Click(object sender, EventArgs e)
        {
            DupCard4.Image = Properties.Resources.Card4;
            compare(DupCard4, Card4);
        }

        private void Card5_Click(object sender, EventArgs e)
        {
            Card5.Image = Properties.Resources.Card5;
            compare(Card5, DupCard5);
        }

        private void DupCard5_Click(object sender, EventArgs e)
        {
            DupCard5.Image = Properties.Resources.Card5;
            compare(DupCard5, Card5);
        }

        private void Card6_Click(object sender, EventArgs e)
        {
            Card6.Image = Properties.Resources.Card6;
            compare(Card6, DupCard6);
        }

        private void DupCard6_Click(object sender, EventArgs e)
        {
            DupCard6.Image = Properties.Resources.Card6;
            compare(DupCard6, Card6);
        }

        private void Card7_Click(object sender, EventArgs e)
        {
            Card7.Image = Properties.Resources.Card7;
            compare(Card7, DupCard7);
        }

        private void DupCard7_Click(object sender, EventArgs e)
        {
            DupCard7.Image = Properties.Resources.Card7;
            compare(DupCard7, Card7);
        }

        private void Card8_Click(object sender, EventArgs e)
        {
            Card8.Image = Properties.Resources.Card8;
            compare(Card8, DupCard8);
        }

        private void DupCard8_Click(object sender, EventArgs e)
        {
            DupCard8.Image = Properties.Resources.Card8;
            compare(DupCard8, Card8);
        }
        #endregion

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            PendingImage1.Image = null;
            PendingImage2.Image = null;
            PendingImage1 = null;
            PendingImage2 = null;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        void compare(PictureBox Card, PictureBox DupCard)
        {
            if (PendingImage1 == null)
            {
                PendingImage1 = Card;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag && PendingImage1 != PendingImage2)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card.Enabled = false;
                    DupCard.Enabled = false;
                    Score.Text = Convert.ToString(Convert.ToInt32(Score.Text) + 10);
                }
                else if (PendingImage1.Tag != PendingImage2.Tag)
                {
                    Score.Text = Convert.ToString(Convert.ToInt32(Score.Text) - 10);
                    timer3.Start();
                }
            }
        }
    }
}
