﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace renkTonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
          label4.ForeColor = Color.FromArgb(int.Parse(numericUpDown1.Value.ToString()), int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown3.Value.ToString()));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(250, 100, 50);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(int.Parse(numericUpDown1.Value.ToString()), int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown3.Value.ToString()));

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(int.Parse(numericUpDown1.Value.ToString()), int.Parse(numericUpDown2.Value.ToString()), int.Parse(numericUpDown3.Value.ToString()));
        }
    }
}
