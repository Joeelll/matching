using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LastTry
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            List<int> mylist = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            List<int> mylist2 = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            Random.Shuffle(mylist);
            Random.Shuffle(mylist2);
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string rnd_file = mylist[mylist.Count].ToString();
            button1.Image = ImageFromFile(rnd_file + ".bmp");
            mylist.Remove(Int32.Parse(rnd_file));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
