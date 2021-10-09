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
        //vengono create tre colonne per suddividere la classifica
        //in seguito vengono presi i valori dal file e dopo, per ogni riga nel, viene creata una nuova riga nella classifica
        private void Classifica()
        {
            Classifica_dgv.Columns.Add("Pos","Posizione");
            Classifica_dgv.Columns.Add("Player", "Giocatore");
            Classifica_dgv.Columns.Add("Nvittorie", "Vittorie");

            string posizione_file = AppDomain.CurrentDomain.BaseDirectory + "Classifica.txt";
            string[] classifica = File.ReadAllLines(posizione_file);
            for(int i = 0; i < classifica.Length; i++)
            {
                string[] giocatore = classifica[i].Split(',');
                Classifica_dgv.Rows.Add(Convert.ToString(i + 1), giocatore[0], giocatore[1]);
            }
        }

        private void bakcbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SchermataPrincipale f1 = new SchermataPrincipale();
            f1.ShowDialog();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
