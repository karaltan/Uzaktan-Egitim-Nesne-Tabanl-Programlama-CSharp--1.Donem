﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace degiskenAktarimi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //BURASI ÇOK ÖNEMLİİİİİİİİİİİİİİ
            int gelendeger = Form1.x;

            label1.Text = gelendeger.ToString();

        }
    }
}
