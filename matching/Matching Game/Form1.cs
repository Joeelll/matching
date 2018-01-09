using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matching_Game
{
    public partial class GameWindow : Form
    {
        int score = 0;
        bool restart = false;
        List<int> X = new List<int>();
        List<int> Y = new List<int>();
        Random Location = new Random();
        public GameWindow()
        {
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            timer2.Start();
            timer1.Start();
            Card1.Image = Properties.Resources.Card1;


            foreach (PictureBox picture in CardPlacement.Controls)
            {
                picture.Image = Properties.Resources.Cover;
            }
        }

        private void CardPlacement_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox picture in CardPlacement.Controls)
            {
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.Cover;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label1.Text);
            timer = timer - 1;
            label1.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer2.Stop();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
