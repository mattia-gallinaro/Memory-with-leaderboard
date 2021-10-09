﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class SchermataPrincipale : Form
    {
        public SchermataPrincipale()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        { 
            ApriSchermataGioco();
        }

        private void ApriSchermataGioco()
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        private void ApriSchermataClassifica()
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void escibtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ApriSchermataClassifica();
        }

        private void SchermataPrincipale_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
