﻿using System;
using System.IO;
using System.Windows.Forms;

namespace RWS
{
    public partial class newMod : Form
    {
        public newMod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          textBox1.Text =  textBox1.Text.Replace('\\', ' ').Replace('/', ' ').Replace('.', ' ').Replace(',', ' ').Replace('%', ' ');
            if (Directory.Exists(@"C:\RWStudio\" + textBox1.Text))
            {
                MessageBox.Show("This mod already created");
            }
            if (!Directory.Exists(@"C:\RWStudio\"+textBox1.Text))
            {
                Directory.CreateDirectory(@"C:\RWStudio\" + textBox1.Text);
                MessageBox.Show("Sucess");
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
