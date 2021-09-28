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
        private struct Fiori
        {
            int posizione;

        }
        //creo array che contengano le quantità di carte generate per avere meno codice 
        List<Fiori> carte = new List<Fiori> { };
        static int tulipani = 0, fiori2 = 0, fiori3 = 0, fiori4 = 0;
        int[] quantitàgenerate = new int[4] { tulipani, fiori2, fiori3, fiori4 };
        string[] fiori = new string[8];
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
            MessageBox.Show("{0}", quantitàgenerate[0].ToString());
            MessageBox.Show("{0}", quantitàgenerate[1].ToString());
            MessageBox.Show("{0}", quantitàgenerate[2].ToString());
            MessageBox.Show("{0}", quantitàgenerate[3].ToString());
        }

        private int controllo(int valore)
        {
            if(quantitàgenerate[valore] == 3)
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
            //switch (numero){
            //    case 0:
            //        if ( < 3)
            //        {
            //            ++;
            //        }
            //        break;
            //    case 1:
            //        if (< 3)
            //        {
            //            ++;
            //        }
            //        break;
            //    case 2:
            //        if ( < 3)
            //        {
            //            ++;
            //        }
            //        break;
            //    case 3:
            //        if( < 3)
            //        {
            //            ++;
            //        }
            //        break;
            //};
            if(quantitàgenerate[numero] < 3)
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
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        //genero un numero, controllo la variabile dei fiori nel caso in cui quel fiore sia stato generato troppe volte allora ne genera un'altro ripetendo il ciclo
        //in un'array collego i fiori ai numeri generati in cui 1 corrisponde ad un fiore 2 ad un'altro e così via
    }
}
