﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaFilm
{
    public partial class PaginaRestrita : Form
    {
        public PaginaRestrita()
        {
            InitializeComponent();
        }

        DateTime time;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void PaginaRestrita_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Relatorios_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            time = DateTime.Now;
            lDataMenu.Text = time.ToShortDateString() + " " + time.ToLongTimeString();
        }
    }

}

