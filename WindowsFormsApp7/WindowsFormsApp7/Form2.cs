using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //private struct FioriList
        //{
        //    int posizione;

        //}
        //creo array che contengano le quantità di carte generate per avere meno codice 
        //List<FioriList> carte = new List<FioriList> { };
        bool turnoG1;
        static int tulipani = 0, fiori2 = 0, fiori3 = 0, fiori4 = 0;
        int[] quantitàgenerate = new int[4] { tulipani, fiori2, fiori3, fiori4 };
        string[] fiori = new string[8];
        PictureBox[] carte = new PictureBox[8];
        int carteselezionate = 0, card1 = 0, card2 = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            GenerazioneCarte();
        }

        private void GenerazioneCarte()
        {
            Random generatore = new Random();
            int numerogen = 0;
            for (int i = 0; i < 8; i++)
            {
                numerogen = generatore.Next(0, 4);
                AumentoConteggioCarte(numerogen);
                if(i > 1 && controllo(numerogen) == -1)
                {
                    i--;
                }
                else
                {
                    //creo carta con rispettivo sfondo e 
                    fiori[i]= AssegnazioneCarte(numerogen);
                }

            }
            AssegnazioneSfondiCarte();
        }
        private void SelezionePrimoGiocatore()
        {
            Random selezione = new Random();
            int turno = selezione.Next(0, 2);
            if(turno == 0)
            {
                turnoG1 = true;
                
            }
            else
            {
                turnoG1 = false;
            }
        }
        private int controllo(int valore)
        {
            if(quantitàgenerate[valore] == 2)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        private void AumentoConteggioCarte(int numero)
        {
            if(quantitàgenerate[numero] < 2)
            {
                quantitàgenerate[numero]++;
            }
        }

        private string AssegnazioneCarte(int indice)
        {
            string tipofiore = "";
            switch (indice)
            {
                case 0:
                    tipofiore = "tulipano";
                    break;
                case 1:
                    tipofiore = "altro";
                    break;
                case 2:
                    tipofiore = "fiore";
                    break;
                case 3:
                    tipofiore = "diverso";
                    break;
            };
            return tipofiore;
        }
        private void AssegnazioneSfondiCarte()
        {
            carta1.Image = Properties.Resources.sfondo_carta;
            carte[1] = carta1;
            carta2.Image = Properties.Resources.sfondo_carta;
            carta3.Image = Properties.Resources.sfondo_carta;
            carta4.Image = Properties.Resources.sfondo_carta;
            carta5.Image = Properties.Resources.sfondo_carta;
            carta6.Image = Properties.Resources.sfondo_carta;
            carta7.Image = Properties.Resources.sfondo_carta;
            carta8.Image = Properties.Resources.sfondo_carta;
        }
        private void GiraCarta(int n1)
        {
            n1 -= 1;
            switch (n1)
            {
                case 0: 
                    carta1.Image = 
                    break;
            }
        }
        private void CartaClick(int indicecarta)
        {
            
        }
        private System.Drawing.Image 
        private void carta1_Click(object sender, EventArgs e)
        {
            CartaClick(1);
        }

        private void carta2_Click(object sender, EventArgs e)
        {
            CartaClick(2);
        }

        private void carta3_Click(object sender, EventArgs e)
        {
            CartaClick(3);
        }

        private void carta4_Click(object sender, EventArgs e)
        {
            CartaClick(4);
        }

        private void carta5_Click(object sender, EventArgs e)
        {
            CartaClick(5);
        }

        private void carta6_Click(object sender, EventArgs e)
        {
            CartaClick(6);
        }

        private void carta7_Click(object sender, EventArgs e)
        {
            CartaClick(7);
        }

        private void carta8_Click(object sender, EventArgs e)
        {
            CartaClick(8);
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //genero un numero, controllo la variabile dei fiori nel caso in cui quel fiore sia stato generato troppe volte allora ne genera un'altro ripetendo il ciclo
        //in un'array collego i fiori ai numeri generati in cui 1 corrisponde ad un fiore 2 ad un'altro e così via
    }
}
