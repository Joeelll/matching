using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matching
{
    public partial class Form1 : Form
    {
        int score = 0;
        Random Location = new Random();
        List<int> X = new List<int>();
        List<int> Y = new List<int>();
        bool again = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Image = null;
            }
        }
    }
}
