﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace LastTry
{
    partial class Form1
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
        

        private void InitializeComponent()
        {

            
            



            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 200);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            string rnd_file = mylist[mylist.Count].ToString();
            button1.Image = Image.FromFile(rnd_file + ".bmp");
            mylist.Remove(Int32.Parse(rnd_file));
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 200);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            string rnd_file2 = mylist[(mylist.Count)-1].ToString();
            button2.Image = Image.FromFile(rnd_file2 + ".bmp");
            mylist.Remove(Int32.Parse(rnd_file2));

            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(440, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 200);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            string rnd_file3 = mylist[mylist.Count-2].ToString();
            button3.Image = Image.FromFile(rnd_file3 + ".bmp");
            mylist.Remove(Int32.Parse(rnd_file3));

            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(646, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 200);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            string rnd_file4 = mylist[mylist.Count - 3].ToString();
            button4.Image = Image.FromFile(rnd_file4 + ".bmp");
            mylist.Remove(Int32.Parse(rnd_file4));

            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 200);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            string rnd_file5 = mylist[mylist.Count - 4].ToString();
            button5.Image = Image.FromFile(rnd_file5 + ".bmp");
            mylist.Remove(Int32.Parse(rnd_file5));

            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(234, 218);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 200);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            string rnd_file6 = mylist[mylist.Count - 5].ToString();
            button6.Image = Image.FromFile(rnd_file6 + ".bmp");
            mylist.Remove(Int32.Parse(rnd_file6));


            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(440, 218);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(200, 200);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            string rnd_file7 = mylist2[mylist2.Count].ToString();
            button7.Image = Image.FromFile(rnd_file7 + ".bmp");
            mylist2.Remove(Int32.Parse(rnd_file7));

            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(646, 218);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(200, 200);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            string rnd_file8 = mylist2[mylist2.Count-1].ToString();
            button8.Image = Image.FromFile(rnd_file8 + ".bmp");
            mylist2.Remove(Int32.Parse(rnd_file8));



            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(646, 424);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(200, 200);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            string rnd_file9 = mylist2[mylist2.Count-2].ToString();
            button9.Image = Image.FromFile(rnd_file9 + ".bmp");
            mylist2.Remove(Int32.Parse(rnd_file9));

            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(440, 424);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(200, 200);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = true;
            string rnd_file10 = mylist2[mylist2.Count-3].ToString();
            button10.Image = Image.FromFile(rnd_file10 + ".bmp");
            mylist2.Remove(Int32.Parse(rnd_file10));

            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(234, 424);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(200, 200);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = true;
            string rnd_file11 = mylist2[mylist2.Count-4].ToString();
            button11.Image = Image.FromFile(rnd_file11 + ".bmp");
            mylist2.Remove(Int32.Parse(rnd_file11));

            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(28, 424);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(200, 200);
            this.button12.TabIndex = 11;
            this.button12.UseVisualStyleBackColor = true;
            string rnd_file12 = mylist2[mylist2.Count-5].ToString();
            button12.Image = Image.FromFile(rnd_file12 + ".bmp");
            mylist2.Remove(Int32.Parse(rnd_file12));

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 678);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}

