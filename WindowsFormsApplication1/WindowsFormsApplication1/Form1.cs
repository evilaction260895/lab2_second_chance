﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tP1_button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(tP1_textBox1.Text);
            b = Convert.ToInt32(tP1_textBox2.Text);
            c = a * b;
            tP1_textBox3.Text = c.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tP2_label1_Red_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.Red;
        }

        private void tP2_label1_Red_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void tP2_label2_Blue_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void tP2_label2_Blue_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void tP2_label3_Green_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.Green;
        }

        private void tP2_label3_Green_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
