﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace degiskenAktarimi_konusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kadi = textBox1.Text;

            Form2 yeni = new Form2();
            yeni.kullaniciAdi = kadi;
            yeni.Show();

            this.Hide();
        }
    }
}
