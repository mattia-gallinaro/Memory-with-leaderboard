using System;
using System.Collections;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Classifica();
        }
        private void Classifica()
        {
            Classifica_dgv.Columns.Add("Pos","Posizione");
            Classifica_dgv.Columns.Add("Player", "Giocatore");
            Classifica_dgv.Columns.Add("Nvittorie", "Vittorie");

            string posizione_file = AppDomain.CurrentDomain.BaseDirectory + "Classifica.txt";
            string[] classifica = File.ReadAllLines(posizione_file);
            for(int i = 0; i < classifica.Length - 1; i++)
            {
                string[] giocatore = classifica[i].Split(',');
                Classifica_dgv.Rows.Add(Convert.ToString(i + 1), giocatore[0], giocatore[1]);
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
