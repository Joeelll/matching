using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matchinggame2
{
    public partial class Form1 : Form
    {
        //variables
        int score = 0; // Meie skoor
        Random Location = new Random(); //paneb igakord randomi kaarditega
        List<int> X = new List<int>(); // x Values of each picturebox
        List<int> Y = new List<int>(); // y values of each picturebox

        bool again = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            foreach(PictureBox picture in CardsHolder.Controls)
            {
                picture.Image = Properties.Resources.Cover;
            }
        }
    }
}
