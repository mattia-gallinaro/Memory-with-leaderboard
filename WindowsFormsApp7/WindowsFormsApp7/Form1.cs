using System;
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
            if (nicktxtbox.Text == "")
            {
                MessageBox.Show("Prima di inziare a giocare/n inserisci un nickname");
            }
            else
            {
                Salvataggio_Nome(nicktxtbox.Text);
            }
        }

        

        private void Salvataggio_Nome(string nick)
        {
            string posizione_file = AppDomain.CurrentDomain.BaseDirectory + "@NomePlayer.txt";
            StreamWriter sw = new StreamWriter(posizione_file, false);
            sw.WriteLine(nick);
            sw.Close();
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

        }
private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
